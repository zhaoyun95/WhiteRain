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
            get { return ObjectManager.WoW.Read<uint>((IntPtr)this.BaseAddress + (int)Offsets.Descriptors.Descriptor); }
        }

        /// <summary>
        /// The objects type
        /// </summary>
        internal int Type
        {
            get { return ObjectManager.WoW.Read<int>((IntPtr) this.BaseAddress + (int)Offsets.WoWObject.Type); }
        }

        /// <summary>
        /// The objects guid
        /// </summary>
        internal ulong Guid
        {
            get { return ObjectManager.WoW.Read<ulong>((IntPtr) this.BaseAddress + (int)Offsets.WoWObject.GUID); }
        }

        /// <summary>
        /// Gets the descriptor value
        /// </summary>
        /// <typeparam name="type">The type</typeparam>
        /// <param name="field">Descriptor</param>
        /// <returns>Descript value</returns>
        internal T GetDescriptorField<T>(uint field) where T : struct
        {
            return (T) ObjectManager.WoW.Read<T>((IntPtr) this.DescriptorBase + (int) field);
        }
    }
}
