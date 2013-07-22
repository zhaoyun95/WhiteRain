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
    /// A corpse
    /// </summary>
    class WoWCorpse : WoWObject
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="BaseAddress"></param>
        public WoWCorpse(uint BaseAddress)
            : base(BaseAddress) { }

        /// <summary>
        /// The owner of the corpse
        /// </summary>
        internal ulong Owner
        {
            get { return ObjectManager.WoW.Read<ulong>((IntPtr)DescriptorBase + (int) Offsets.WoWCorpse.Owner); }
        }

        /// <summary>
        /// Is this my corpse? :(
        /// </summary>
        internal bool MyCorpse
        {
            get
            {
                if (Owner == ObjectManager.Me.Guid)
                    return true;
                return false;
            }
        }

        /// <summary>
        /// The displayId of the corpse
        /// </summary>
        internal int DisplayId
        {
            get { return GetDescriptorField<int>((uint)Offsets.WoWCorpse.DisplayID); }
        }

        /// <summary>
        /// The corpse dynamic flags
        /// </summary>
        internal BitVector32 DynamicFlags
        {
            get { return GetDescriptorField<BitVector32>((uint)Offsets.WoWCorpse.DynamicFlags); }
        }

        /// <summary>
        /// The corpse flags
        /// </summary>
        internal BitVector32 Flags
        {
            get { return GetDescriptorField<BitVector32>((uint)Offsets.WoWCorpse.Flags); }
        }

        /// <summary>
        /// The corpse position
        /// </summary>
        internal Vector3 Position
        {
            get
            {
                if (MyCorpse)
                {
                    return new Vector3{
                        X = ObjectManager.WoW.Read<float>((IntPtr)ObjectManager.WoW.ImageBase + (int)Offsets.WoWCorpse.Player_Corpse_X),
                        Y = ObjectManager.WoW.Read<float>((IntPtr)ObjectManager.WoW.ImageBase + (int)Offsets.WoWCorpse.Player_Corpse_Y),
                        Z = ObjectManager.WoW.Read<float>((IntPtr)ObjectManager.WoW.ImageBase + (int)Offsets.WoWCorpse.Player_Corpse_Z)
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
