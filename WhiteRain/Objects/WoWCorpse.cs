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
    /// A corpse
    /// </summary>
    public class WoWCorpse : WoWObject
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="BaseAddress"></param>
        public WoWCorpse(IntPtr BaseAddress)
            : base(BaseAddress) { }

        /// <summary>
        /// The owner of the corpse
        /// </summary>
        public ulong Owner
        {
            get { return WhiteRain.WoW.Read<ulong>((IntPtr)DescriptorBase + (int) Offsets.WoWCorpse.Owner); }
        }

        /// <summary>
        /// Is this my corpse? :(
        /// </summary>
        public bool MyCorpse
        {
            get
            {
                if (Owner == WhiteRain.Me.Guid)
                    return true;
                return false;
            }
        }

        /// <summary>
        /// The displayId of the corpse
        /// </summary>
        public int DisplayId
        {
            get { return GetDescriptorField<int>((uint)Offsets.WoWCorpse.DisplayID); }
        }

        /// <summary>
        /// The corpse dynamic flags
        /// </summary>
        public BitVector32 DynamicFlags
        {
            get { return GetDescriptorField<BitVector32>((uint)Offsets.WoWCorpse.DynamicFlags); }
        }

        /// <summary>
        /// The corpse flags
        /// </summary>
        public BitVector32 Flags
        {
            get { return GetDescriptorField<BitVector32>((uint)Offsets.WoWCorpse.Flags); }
        }

        /// <summary>
        /// The corpse position
        /// </summary>
        public Vector3 Position
        {
            get
            {
                if (MyCorpse)
                {
                    return new Vector3{
                        X = WhiteRain.WoW.Read<float>((IntPtr)WhiteRain.WoW.ImageBase + (int)Offsets.WoWCorpse.Player_Corpse_X),
                        Y = WhiteRain.WoW.Read<float>((IntPtr)WhiteRain.WoW.ImageBase + (int)Offsets.WoWCorpse.Player_Corpse_Y),
                        Z = WhiteRain.WoW.Read<float>((IntPtr)WhiteRain.WoW.ImageBase + (int)Offsets.WoWCorpse.Player_Corpse_Z)
                    };
                }
                else
                {
                    return new Vector3 { X = 0, Y = 0, Z = 0 };
                }
            }
        }
    }
}
