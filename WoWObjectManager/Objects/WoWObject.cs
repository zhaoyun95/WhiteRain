/*
 * This file is part of the WoWObjectManager (C) 2013 Finn Grimpe
 * Copyright 2013 Finn Grimpe, All Rights Reserved
 * 
 * Github:  https://github.com/finndev/WoWObjectManager/
 * Website: http://finn.lu/
 * License: http://finn.lu/license
 *
 */

using System;

namespace WoWObjectManager
{
    /// <summary>
    /// An object.
    /// </summary>
    class WoWObject
    {
        /// <summary>
        /// Instantiates a new WoWUnit
        /// </summary>
        /// <param name="baseAddr">The object's base address</param>
        public WoWObject(uint BaseAddress)
        {
            this.BaseAddress = BaseAddress;
        }

        /// <summary>
        /// The objects base address
        /// </summary>
        public uint BaseAddress { get; set; }

        /// <summary>
        /// The objects type
        /// </summary>
        public uint Type
        {
            get { return ObjectManager.WoW.ReadUInt(this.BaseAddress + (Int32)Offsets.WoWObject.Type); }
        }

        //The objects guid
        public ulong Guid
        {
            get { return ObjectManager.WoW.ReadUInt64(this.BaseAddress + (Int32)Offsets.WoWObject.GUID); }
        }
    }
}
