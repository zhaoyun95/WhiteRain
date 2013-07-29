/*
 * This file is part of the WoWObjectManager (C) 2013 Finn Grimpe
 * Copyright 2013 Finn Grimpe, All Rights Reserved
 * 
 * Github:  https://github.com/finndev/WoWObjectManager/
 * Website: http://finn.lu/
 * License: http://finn.lu/license
 *
 */

using GreyMagic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using whiteRain.Objects;

namespace whiteRain
{
    public class WhiteRain
    {
        /// <summary>
        /// GreyMagic instance. ♥
        /// </summary>
        public static ExternalProcessReader WoW { get; set; }

        /// <summary>
        /// A list of all units.
        /// </summary>
        public static List<WoWUnit> WoWUnitList = new List<WoWUnit>();

        /// <summary>
        /// A list of all gameobjects.
        /// </summary>
        public static List<WoWGameObject> WoWGameObjectList = new List<WoWGameObject>();

        /// <summary>
        /// A list of all corpses.
        /// </summary>
        public static List<WoWCorpse> WoWCorpseList = new List<WoWCorpse>();

        /// <summary>
        /// A list of all items.
        /// </summary>
        public static List<WoWItem> WoWItemList = new List<WoWItem>();

        /// <summary>
        /// Storage 
        /// </summary>
        public static uint CurObj, ObjMgr;

        /// <summary>
        /// The local's player GUID
        /// </summary>
        public static ulong PlayerGUID { get; set; }

        /// <summary>
        /// The local player object
        /// </summary>
        public static WoWPlayerMe Me { get; set; }

        /// <summary>
        /// Returns whether the ObjectManager is initialized or not
        /// </summary>
        public static bool Initialized { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public struct LaunchParameters
        {
            public bool UpdateAutomatically { get; set; }
        }

        public static string md5_file(string filename, bool raw_output = false)
        {
            using (MD5CryptoServiceProvider hashProvider = new MD5CryptoServiceProvider())
            {
                byte[] hash = hashProvider.ComputeHash(File.ReadAllBytes(filename));

                if (raw_output)
                {
                    return Encoding.UTF8.GetString(hash);
                }
                else
                {
                    StringBuilder stringBuilder = new StringBuilder();

                    foreach (byte b in hash)
                    {
                        stringBuilder.Append(b.ToString("x2"));
                    }

                    return stringBuilder.ToString();
                }
            }
        }

        /// <summary>
        /// Initialize the ObjectManager and attaches BlackMagic to the processId.
        /// </summary>
        public static void Initialize(Process proc, LaunchParameters Parameters = new LaunchParameters())
        {
            if (Initialized)
                return;

            try
            {
                WoW = new ExternalProcessReader(proc);

                if (Parameters.UpdateAutomatically)
                {
                    File.WriteAllText(Application.StartupPath + "/version.txt", Application.StartupPath);
                    using (WebClient wc = new WebClient())
                    {
                        string onlineVersion = wc.DownloadString("https://finn.lu/update/whiterain.php?action=version");
                        if (onlineVersion != md5_file(string.Format("{0}/{1}", Application.StartupPath, "WhiteRain.dll")))
                        {
                            Process.Start("WhiteRain.Updater.exe");
                            Process.GetCurrentProcess().Kill();
                            System.Environment.Exit(0);
                            Application.Exit();
                        }
                    }
                }

                ObjMgr = WoW.Read<uint>((IntPtr)WoW.Read<uint>(WoW.ImageBase + (int)Offsets.ObjectManager.clientConnection) + (int)Offsets.ObjectManager.objectManager);
                CurObj = WoW.Read<uint>((IntPtr)ObjMgr + (int)Offsets.ObjectManager.FirstObject);

                PlayerGUID = WoW.Read<ulong>((IntPtr)ObjMgr + (int)Offsets.ObjectManager.LocalGUID);

                Initialized = true;
                Pulse();
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Failed to initialize the WhiteRain. Error: {0}", ex.Message));
            }
        }


        /// <summary>
        /// Pulses the Objectmanager and refreshes every object it currently holds
        /// </summary>
        public static void Pulse()
        {
            if (!Initialized)
                return;

            CurObj = WoW.Read<uint>((IntPtr) ObjMgr + (int) Offsets.ObjectManager.FirstObject);
            
            lock (WoWUnitList) lock (WoWCorpseList) lock (WoWItemList) lock(WoWGameObjectList)
            {

                if (WoWUnitList.Count > 0)
                    WoWUnitList.Clear();
                if (WoWCorpseList.Count > 0)
                    WoWCorpseList.Clear();
                if (WoWItemList.Count > 0)
                    WoWItemList.Clear();

                while (CurObj != 0 && (CurObj & 1) == 0)
                {
                    WoWObject WoWObject = new WoWObject((IntPtr)CurObj);
                    uint NextObj = WoW.Read<uint>((IntPtr)CurObj + (int)Offsets.ObjectManager.NextObject);

                    if (WoWObject.Guid == PlayerGUID)
                        Me = new WoWPlayerMe((IntPtr)CurObj);

                    switch (WoWObject.Type)
                    {
                        case (int)WoWObjectType.Item:
                            WoWItemList.Add(new WoWItem((IntPtr)CurObj));
                            break;
                        case (int)WoWObjectType.Corpse:
                            WoWCorpseList.Add(new WoWCorpse((IntPtr)CurObj));
                            break;
                        case (int)WoWObjectType.Unit:
                            WoWUnitList.Add(new WoWUnit((IntPtr)CurObj));
                            break;
                        case (int)WoWObjectType.GameObject:
                            WoWGameObjectList.Add(new WoWGameObject((IntPtr)CurObj));
                            break;
                        case (int)WoWObjectType.Container:

                            break;
                    }

                    CurObj = NextObj;
                }
            }
        }
    }
}
