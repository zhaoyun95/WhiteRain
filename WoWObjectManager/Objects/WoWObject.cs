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
using System.Collections.Specialized;

namespace WoWObjectManager.Objects
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
        internal WoWObject(uint BaseAddress)
        {
            this.BaseAddress = BaseAddress;
        }

        /// <summary>
        /// The objects base address
        /// </summary>
        internal uint BaseAddress { get; set; }

        internal uint DescriptorBase
        {
            get { return ObjectManager.WoW.ReadUInt((uint)this.BaseAddress + (int)Offsets.Descriptors.Descriptor); }
        }

        /// <summary>
        /// The objects type
        /// </summary>
        internal int Type
        {
            get { return ObjectManager.WoW.ReadInt(this.BaseAddress + (int)Offsets.WoWObject.Type); }
        }

        /// <summary>
        /// The objects guid
        /// </summary>
        internal ulong Guid
        {
            get { return ObjectManager.WoW.ReadUInt64(this.BaseAddress + (int)Offsets.WoWObject.GUID); }
        }

        
        /// <summary>
        /// Checks whether the unit has that dynamic flag or not
        /// </summary>
        /// <param name="flag">The dynamicFlag</param>
        /// <returns>true or false</returns>
        /*internal bool HasDynamicFlag(Offsets.UnitDynamicFlags flag)
        {
            return DynamicFlags[(int)flag];
        }*/

        /// <summary>
        /// The objects dynamic flags
        /// </summary> 
        /*
        internal dynamic DynamicFlags
        {
            get {
                return ObjectManager.WoW.ReadByte(ObjectManager.WoW.ReadUInt(this.BaseAddress + 0x180));
            }
        }*/


        /// <summary>
        /// Gets the descriptor value
        /// </summary>
        /// <typeparam name="type">The type</typeparam>
        /// <param name="field">Descriptor</param>
        /// <returns>Descript value</returns>
        internal type GetDescriptorField<type>(uint field) where type : struct
        {
            return (type)ObjectManager.WoW.ReadObject(this.DescriptorBase + field, typeof(type));
        }

    }
}
