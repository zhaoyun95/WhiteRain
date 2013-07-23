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
using System.ComponentModel;
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
        public WoWUnit(IntPtr BaseAddress)
            : base(BaseAddress) { }


        [Category("Informations")]
        [Description("Vector3 of the unit's position. Position.X to access the X-coordinate as example.")]
        /// <summary>
        /// Returns the postion as Vector3.
        /// </summary>
        public Vector3 Position
        {
            get
            {
                return new Vector3 {
                    X = ObjectManager.WoW.Read<float>(BaseAddress + (int)Offsets.WoWUnit.X),
                    Y = ObjectManager.WoW.Read<float>(BaseAddress + (int)Offsets.WoWUnit.Y),
                    Z = ObjectManager.WoW.Read<float>(BaseAddress + (int)Offsets.WoWUnit.Z)
                };
            }
        }

        [Category("Informations")]
        [Description("The name of the unit. Never use this if you're planning to write a bot due to different languages.")]
        /// <summary>
        /// The units name
        /// </summary>
        public string Name
        {
            get { return ObjectManager.WoW.ReadString((IntPtr) ObjectManager.WoW.Read<uint>((IntPtr) ObjectManager.WoW.Read<uint>((IntPtr) BaseAddress + (int)Offsets.WoWUnit.NamePointer) + (int) Offsets.WoWUnit.NameOffset), Encoding.UTF8); }
        }

        [Category("Informations")]
        [Description("The DisplayId of the unit. Useful if you're planning to write a Grindbot. Kill all mobs with DisplayID 1337 (wolf!).")]
        /// <summary>
        /// The units DisplayId
        /// </summary>
        public int DisplayId
        {
            get { return GetDescriptorField<int>((uint)Offsets.WoWUnit.DisplayID); }
        }


        /// <summary>
        /// The NativeDisplayID of the unit.
        /// </summary>
        public int NativeDisplayID
        {
            get { return GetDescriptorField<int>((uint)Offsets.WoWUnit.NativeDisplayID); }
        }

        [Category("Informations")]
        [Description("The base health of the unit.")]
        /// <summary>
        /// The base health of the unit.
        /// </summary>
        public int BaseHealth
        {
            get { return GetDescriptorField<int>((uint)Offsets.WoWUnit.Health); }
        }

        [Category("Informations")]
        [Description("The maximum health of the unit.")]
        /// <summary>
        /// The maximum health of the unit.
        /// </summary>
        public int MaxHealth
        {
            get { return GetDescriptorField<int>((uint)Offsets.WoWUnit.MaxHealth); }
        }

        [Category("Informations")]
        [Description("The base power of the unit.")]
        /// <summary>
        /// The base power of the unit.
        /// </summary>
        public int BasePower
        {
            get { return GetDescriptorField<int>((uint)Offsets.WoWUnit.Power); }
        }

        [Category("Informations")]
        [Description("The maximum power of the unit.")]
        /// <summary>
        /// The maximum power of the unit.
        /// </summary>
        public int MaxPower
        {
            get { return GetDescriptorField<int>((uint)Offsets.WoWUnit.MaxPower); }
        }

        [Category("Informations")]
        [Description("The level of the unit.")]
        /// <summary>
        /// The level of the unit.
        /// </summary>
        public int Level
        {
            get { return GetDescriptorField<int>((uint)Offsets.WoWUnit.Level); }
        }

        [Category("Informations")]
        [Description("Returns true if the is alive, false if not.")]
        /// <summary>
        /// Returns whether the unit is alive or not.
        /// </summary>
        public bool IsAlive
        {
            get { return (HasFlag(Offsets.UnitDynamicFlags.Dead)) ? true : false; }
        }

        [Category("Informations")]
        [Description("The target's guid of the unit.")]
        /// <summary>
        /// The target's guid of the unit.
        /// </summary>
        public ulong TargetGUID
        {
            get { return GetDescriptorField<UInt64>((uint)Offsets.WoWUnit.Target); }
        }


        [Category("Informations")]
        [Description("Returns true if the unit is a NPC, false if not.")]
        /// <summary>
        /// Is the unit a NPC?
        /// </summary>
        public bool IsNPC
        {
            //Ugly, as UnitRelation is missing.
            get
            {
                foreach (Offsets.WoWNpcFlags flag in Enum.GetValues(typeof(Offsets.WoWNpcFlags)))
                {
                    if (HasFlag(flag) && flag != Offsets.WoWNpcFlags.None)
                        return true;
                }

                return false;
            }
        }

        [Category("Misc")]
        [Description("The Guid of the unit by whom it's charmed by.")]
        /// <summary>
        /// The GUID of the object this unit is charmed by
        /// </summary>
        public ulong CharmedBy
        {
            get { return GetDescriptorField<ulong>((uint)Offsets.WoWUnit.CharmedBy); }
        }

        [Category("Misc")]
        [Description("The Guid of the unit by whom it's summoned by. Example: Hunter Pet, Warlock Pets")]
        /// <summary>
        /// The GUID of the object this unit is summoned by
        /// </summary>
        public ulong SummonedBy
        {
            get { return GetDescriptorField<ulong>((uint)Offsets.WoWUnit.SummonedBy); }
        }

        [Category("Misc")]
        [Description("The Guid of the unit by whom its created by. Example: Hunter Pet, Warlock Pets")]
        /// <summary>
        /// The GUID of the object this unit is created by
        /// </summary>
        public ulong CreatedBy
        {
            get { return GetDescriptorField<ulong>((uint)Offsets.WoWUnit.CreatedBy); }
        }

        [Category("Misc")]
        [Description("The NPCFlags of the unit. Check (enum) WoWNpcFlags.")]
        /// <summary>
        /// The units NPCFlags
        /// </summary>
        public BitVector32 NPCFlags
        {
            get { return GetDescriptorField<BitVector32>((uint)Offsets.WoWUnit.NpcFlags); }
        }

        [Category("Misc")]
        [Description("Use this, to check if the unit has the flag or not. Usable with every flag that exist.")]
        /// <summary>
        /// Checks whether the unit has that npc flag or not
        /// </summary>
        /// <param name="flag">The NpcFlag</param>
        /// <returns>true or false</returns>
        public bool HasFlag(Offsets.UnitFlags flag)
        {
            return Flags[(int)flag];
        }

        [Category("Misc")]
        [Description("Use this, to check if the unit has the flag or not. Usable with every flag that exist.")]
        /// <summary>
        /// Checks whether the unit has that npc flag or not
        /// </summary>
        /// <param name="flag">The NpcFlag</param>
        /// <returns>true or false</returns>
        public bool HasFlag(Offsets.WoWNpcFlags flag)
        {
            return NPCFlags[(int)flag];
        }

        [Category("Misc")]
        [Description("Use this, to check if the unit has the flag or not. Usable with every flag that exist.")]
        /// <summary>
        /// Checks whether the unit has that npc flag or not
        /// </summary>
        /// <param name="flag">The NpcFlag</param>
        /// <returns>true or false</returns>
        public dynamic HasFlag(Offsets.UnitDynamicFlags flag)
        {
            return DynamicFlags[(int)flag];
        }

        [Category("Misc")]
        [Description("The flags of the unit. Check (enum) UnitFlags.")]
        /// <summary>
        /// The units NPCFlags
        /// </summary>
        public BitVector32 Flags
        {
            get { return GetDescriptorField<BitVector32>((uint)Offsets.WoWUnit.Flags); }
        }

        [Category("Misc")]
        [Description("The dynamic flags of the unit. Check (enum) UnitDynamicFlags.")]
        /// <summary>
        /// The objects DynamicFlags
        /// </summary>
        public BitVector32 DynamicFlags
        {
            get { return GetDescriptorField<BitVector32>((uint)Offsets.WoWObject.DynamicFlags); }
        }

    }

}
