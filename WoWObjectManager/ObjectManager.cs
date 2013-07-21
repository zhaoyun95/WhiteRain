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
using System.Linq;
using WoWObjectManager.Objects;

namespace WoWObjectManager
{
    class ObjectManager
    {
        /// <summary>
        /// GreyMagic instance. ♥
        /// </summary>
        internal static ExternalProcessReader WoW { get; set; }

        /// <summary>
        /// A list of all units.
        /// </summary>
        internal static List<WoWUnit> WoWUnitList = new List<WoWUnit>();

        /// <summary>
        /// A list of all corpses.
        /// </summary>
        internal static List<WoWCorpse> WoWCorpseList = new List<WoWCorpse>();

        /// <summary>
        /// A list of all items.
        /// </summary>
        internal static List<WoWItem> WoWItemList = new List<WoWItem>();

        /// <summary>
        /// Storage 
        /// </summary>
        internal static uint CurObj, ObjMgr;

        /// <summary>
        /// The local's player GUID
        /// </summary>
        internal static ulong PlayerGUID { get; set; }

        /// <summary>
        /// The local player object
        /// </summary>
        internal static WoWPlayerMe Me { get; set; }

        /// <summary>
        /// Returns whether the ObjectManager is initialized or not
        /// </summary>
        internal static bool Initialized { get; set; }

        /// <summary>
        /// Initialize the ObjectManager and attaches BlackMagic to the processId.
        /// </summary>
        internal static void Initialize(Process proc)
        {
            if (Initialized)
                return;

            try
            {
                WoW = new ExternalProcessReader(proc);
                ObjMgr = WoW.Read<uint>((IntPtr) WoW.Read<uint>(WoW.ImageBase + (int)Offsets.ObjectManager.clientConnection) + (int) Offsets.ObjectManager.ObjectManager);
                CurObj = WoW.Read<uint>((IntPtr) ObjMgr + (int) Offsets.ObjectManager.FirstObject);

                PlayerGUID = WoW.Read<ulong>((IntPtr) ObjMgr + (int) Offsets.ObjectManager.LocalGUID);

                Initialized = true;
                Pulse();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Couldn't initialize the ObjectManager. New patch available? Invalid process id?");
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Pulses the Objectmanager and refreshes every object it currently holds
        /// </summary>
        internal static void Pulse()
        {
            if (!Initialized)
                return;

            CurObj = WoW.Read<uint>((IntPtr) ObjMgr + (int) Offsets.ObjectManager.FirstObject);

            if (WoWUnitList.Count > 0)
                WoWUnitList.Clear();
            if (WoWCorpseList.Count > 0)
                WoWCorpseList.Clear();
            if (WoWItemList.Count > 0)
                WoWItemList.Clear();

            while (CurObj != 0 && (CurObj & 1) == 0)
            {
                WoWObject WoWObject = new WoWObject(CurObj);
                uint NextObj = WoW.Read<uint>((IntPtr) CurObj + (int) Offsets.ObjectManager.NextObject);

                if (WoWObject.Guid == PlayerGUID)
                    Me = new WoWPlayerMe(CurObj);

                switch (WoWObject.Type)
                {
                    case (int) WoWObjectType.Item:
                        WoWItemList.Add(new WoWItem(CurObj));
                        break;
                    case (int) WoWObjectType.Corpse:
                        WoWCorpseList.Add(new WoWCorpse(CurObj));
                        break;
                    case (int) WoWObjectType.Unit:
                        WoWUnitList.Add(new WoWUnit(CurObj));
                        break;
                    case (int) WoWObjectType.Container:

                        break;
                }

                CurObj = NextObj;
            }
        }
    }
}
