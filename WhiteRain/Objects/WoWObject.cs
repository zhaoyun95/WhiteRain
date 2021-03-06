﻿/*
 * This file is part of the WhiteRain project (C) 2013 Finn Grimpe
 * Copyright 2013 Finn Grimpe, All Rights Reserved
 * 
 * Github:  https://github.com/finndev/WhiteRain/
 * Website: https://finn.lu/whiterain/
 * License: https://finn.lu/license/
 *
 */

using System;
using System.Collections.Specialized;
using System.ComponentModel;

namespace WhiteRainNS.Objects
{
    /// <summary>
    /// An object.
    /// </summary>
    public class WoWObject
    {
        /// <summary>
        /// Instantiates a new WoWUnit
        /// </summary>
        /// <param name="baseAddr">The object's base address</param>
        public WoWObject(IntPtr BaseAddress)
        {
            this.BaseAddress = BaseAddress;
        }

        [Category("General")]
        [Description("The objects base address pointer.")]
        /// <summary>
        /// The objects base address pointer.
        /// </summary>
        public IntPtr BaseAddress { get; set; }

        [Category("General")]
        [Description("The objects descriptor base pointer.")]
        /// <summary>
        /// The objects descriptor base pointer.
        /// </summary>
        public IntPtr DescriptorBase
        {
            get { return WhiteRain.WoW.Read<IntPtr>(BaseAddress + (int)Offsets.Descriptors.Descriptor); }
        }

        [Category("Informations")]
        [Description("The objects entry ID.")]
        /// <summary>
        /// The objects entry ID.
        /// </summary>
        public int EntryID
        {
            get { return WhiteRain.WoW.Read<int>(BaseAddress + (int)Offsets.WoWObject.EntryID); }
        }

        [Category("Informations")]
        [Description("There are several ObjectTypes. Take a look at (enum) WoWObjectType")]
        /// <summary>
        /// The objects type
        /// </summary>
        public int Type
        {
            get { return WhiteRain.WoW.Read<int>(BaseAddress + (int)Offsets.WoWObject.Type); }
        }

        [Category("Informations")]
        [Description("Every object has an unique Guid. Use this to identify and access the object.")]
        /// <summary>
        /// The objects Guid
        /// </summary>
        public ulong Guid
        {
            get { return WhiteRain.WoW.Read<ulong>(BaseAddress + (int)Offsets.WoWObject.GUID); }
        }

        /// <summary>
        /// Gets the descriptor value
        /// </summary>
        /// <typeparam name="type">The type</typeparam>
        /// <param name="field">Descriptor</param>
        /// <returns>Descript value</returns>
        public T GetDescriptorField<T>(uint field) where T : struct
        {
            return (T) WhiteRain.WoW.Read<T>(DescriptorBase + (int) field);
        }
    }
}
