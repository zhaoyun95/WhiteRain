/*
 * This file is part of the WhiteRain project (C) 2013 Finn Grimpe
 * Copyright 2013 Finn Grimpe, All Rights Reserved
 * 
 * Github:  https://github.com/finndev/WhiteRain/
 * Website: https://finn.lu/whiterain/
 * License: https://finn.lu/license
 *
 */

using System;
using System.Collections.Specialized;

namespace WhiteRainNS.Objects
{
    /// <summary>
    /// A WoWitem
    /// </summary>
    public class WoWGameObject : WoWObject
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="BaseAddress"></param>
        public WoWGameObject(IntPtr BaseAddress)
            : base(BaseAddress) { }

        /// <summary>
        /// The gameobject created by GUID
        /// </summary>
        public ulong CreatedBy
        {
            get { return GetDescriptorField<ulong>((uint)Offsets.WoWGameObject.CreatedBy); }
        }

        /// <summary>
        /// The displayId of the gameobject
        /// </summary>
        public int DisplayId
        {
            get { return GetDescriptorField<int>((uint)Offsets.WoWGameObject.DisplayID); }
        }

        /// <summary>
        /// The flags of the gameobject
        /// </summary>
        public BitVector32 Flags
        {
            get { return GetDescriptorField<BitVector32>((uint)Offsets.WoWGameObject.Flags); }
        }
    }
}
