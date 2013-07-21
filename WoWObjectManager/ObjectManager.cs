/*
 * This file is part of the WoWObjectManager (C) 2013 Finn Grimpe
 * Copyright 2013 Finn Grimpe, All Rights Reserved
 * 
 * Github:  https://github.com/finndev/WoWObjectManager/
 * Website: http://finn.lu/
 * License: http://finn.lu/license
 *
 */

using Magic;
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
        /// BlackMagic instance.
        /// </summary>
        internal static BlackMagic WoW { get; set; }

        /// <summary>
        /// A list of all units.
        /// </summary>
        internal static IDictionary<ulong, WoWUnit> WoWUnitList = new Dictionary<ulong, WoWUnit>();

        /// <summary>
        /// A list of all corpses.
        /// </summary>
        internal static IDictionary<ulong, WoWCorpse> WoWCorpseList = new Dictionary<ulong, WoWCorpse>();

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
        internal static void Initialize()
        {
            if (Initialized)
                return;

            try
            {
                WoW = new BlackMagic((from Process p in Process.GetProcesses() where p.ProcessName == "Wow" select p.Id).First());
                ObjMgr = WoW.ReadUInt(WoW.ReadUInt((uint)WoW.MainModule.BaseAddress + (uint)Offsets.ObjectManager.clientConnection) + (uint)Offsets.ObjectManager.ObjectManager);
                CurObj = WoW.ReadUInt(ObjMgr + (int)Offsets.ObjectManager.FirstObject);

                PlayerGUID = WoW.ReadUInt64(ObjMgr + (int)Offsets.ObjectManager.LocalGUID);

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

            CurObj = WoW.ReadUInt(ObjMgr + (int)Offsets.ObjectManager.FirstObject);

            if (WoWUnitList.Count > 0)
                WoWUnitList.Clear();
            if (WoWCorpseList.Count > 0)
                WoWCorpseList.Clear();

            while (CurObj != 0 && (CurObj & 1) == 0)
            {
                WoWObject WoWObject = new WoWObject(CurObj);
                uint NextObj = WoW.ReadUInt(CurObj + (int)Offsets.ObjectManager.NextObject);

                if (WoWObject.Guid == PlayerGUID)
                    Me = new WoWPlayerMe(CurObj);

                switch (WoWObject.Type)
                {
                    case (int) WoWObjectType.Corpse:
                        WoWCorpse WoWCorpse = new WoWCorpse(CurObj);
                        WoWCorpseList.Add(WoWCorpse.Guid, WoWCorpse);
                        break;
                    case (int) WoWObjectType.Unit:
                        WoWUnit WoWUnit = new WoWUnit(CurObj);
                        WoWUnitList.Add(WoWUnit.Guid, WoWUnit);
                        break;
                }

                CurObj = NextObj;
            }
        }
    }
}
