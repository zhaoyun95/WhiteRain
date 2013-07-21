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
using System.Text;

namespace WoWObjectManager.Objects
{
    /// <summary>
    /// An unit (Monster, NPCs)
    /// </summary>
    class WoWUnit : WoWObject
    {
        /// <summary>
        /// Instantiates a new WoWUnit
        /// </summary>
        /// <param name="BaseAddress">The units base address.</param>
        public WoWUnit(uint BaseAddress)
            : base(BaseAddress) { }

        /// <summary>
        /// Returns the postion as Vector3.
        /// </summary>
        internal Vector3 Position
        {
            get
            {
                return new Vector3(
                    GetDescriptorField<float>((uint)Offsets.WoWUnit.X),
                    GetDescriptorField<float>((uint)Offsets.WoWUnit.Y),
                    GetDescriptorField<float>((uint)Offsets.WoWUnit.Z)
                    );
            }
        }

        /// <summary>
        /// The units name
        /// </summary>
        internal string Name
        {
            get { return ObjectManager.WoW.ReadString((IntPtr) ObjectManager.WoW.Read<uint>((IntPtr) ObjectManager.WoW.Read<uint>((IntPtr) BaseAddress + (int)Offsets.WoWUnit.NamePointer) + (int) Offsets.WoWUnit.NameOffset), Encoding.ASCII); }
        }

        /// <summary>
        /// The GUID of the object this unit is charmed by
        /// </summary>
        internal ulong CharmedBy
        {
            get { return GetDescriptorField<ulong>((uint)Offsets.WoWUnit.CharmedBy); }
        }

        /// <summary>
        /// The GUID of the object this unit is summoned by
        /// </summary>
        internal ulong SummonedBy
        {
            get { return GetDescriptorField<ulong>((uint)Offsets.WoWUnit.SummonedBy); }
        }

        /// <summary>
        /// The GUID of the object this unit is created by
        /// </summary>
        internal ulong CreatedBy
        {
            get { return GetDescriptorField<ulong>((uint)Offsets.WoWUnit.CreatedBy); }
        }

        /// <summary>
        /// The units displayId
        /// </summary>
        internal int DisplayId
        {
            get { return GetDescriptorField<int>((uint)Offsets.WoWUnit.DisplayID); }
        }

        /// <summary>
        /// The units native displayId
        /// </summary>
        internal int NativeDisplayId
        {
            get { return GetDescriptorField<int>((uint)Offsets.WoWUnit.NativeDisplayID);  }
        }

        /// <summary>
        /// The units base health
        /// </summary>
        internal int BaseHealth
        {
            get { return GetDescriptorField<int>((uint)Offsets.WoWUnit.Health); }
        }

        /// <summary>
        /// The units max health
        /// </summary>
        internal int MaxHealth
        {
            get { return GetDescriptorField<int>((uint)Offsets.WoWUnit.MaxHealth); }
        }

        /// <summary>
        /// The units base power
        /// </summary>
        internal int BasePower
        {
            get { return GetDescriptorField<int>((uint)Offsets.WoWUnit.Power); }
        }

        /// <summary>
        /// The units max power
        /// </summary>
        internal int MaxPower
        {
            get { return GetDescriptorField<int>((uint)Offsets.WoWUnit.MaxPower); }
        }


        /// <summary>
        /// The units level
        /// </summary>
        internal int Level
        {
            get { return GetDescriptorField<int>((uint)Offsets.WoWUnit.Level); }
        }

        /// <summary>
        /// Returns whether the unit is alive or not.
        /// </summary>
        internal bool IsAlive
        {
            get
            {
                if (BaseHealth > 0)
                    return true;
                return false;
            }
        }

        /// <summary>
        /// The units target GUID
        /// </summary>
        internal ulong TargetGUID
        {
            get { return GetDescriptorField<UInt64>((uint)Offsets.WoWUnit.Target); }
        }

        /// <summary>
        /// Checks whether the unit has that npc flag or not
        /// </summary>
        /// <param name="flag">The NpcFlag</param>
        /// <returns>true or false</returns>
        internal bool HasNPCFlag(Offsets.WoWNpcFlags flag)
        {
            return NPCFlags[(int)flag];
        }

        /// <summary>
        /// The units NPCFlags
        /// </summary>
        internal BitVector32 NPCFlags
        {
            get { return GetDescriptorField<BitVector32>((uint)Offsets.WoWUnit.NpcFlags); }
        }

        /// <summary>
        /// Checks whether the unit has that npc flag or not
        /// </summary>
        /// <param name="flag">The NpcFlag</param>
        /// <returns>true or false</returns>
        internal bool HasFlag(Offsets.UnitFlags flag)
        {
            return Flags[(int)flag];
        }

        /// <summary>
        /// The units NPCFlags
        /// </summary>
        internal BitVector32 Flags
        {
            get { return GetDescriptorField<BitVector32>((uint)Offsets.WoWUnit.Flags); }
        }

        /// <summary>
        /// Checks whether the unit has that dynamic flag or not
        /// </summary>
        /// <param name="flag">The DynamicFlag</param>
        /// <returns>true or false</returns>
        internal bool HasDynamicFlag(Offsets.UnitDynamicFlags flag)
        {
            return DynamicFlags[(int)flag];
        }

        /// <summary>
        /// The objects DynamicFlags
        /// </summary>
        internal BitVector32 DynamicFlags
        {
            get { return GetDescriptorField<BitVector32>((uint)Offsets.WoWObject.DynamicFlags); }
        }
    }

}
