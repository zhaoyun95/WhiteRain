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
using System.Text;

namespace WoWObjectManager.Objects
{
    /// <summary>
    /// Repesents the local player
    /// </summary>
    class WoWPlayerMe : WoWObject
    {
        internal WoWPlayerMe(IntPtr BaseAddress)
            : base(BaseAddress) { }

        /// <summary>
        /// The players name
        /// </summary>
        internal string Name
        {
            get { return ObjectManager.WoW.ReadString((IntPtr) ObjectManager.WoW.ImageBase + (int)Offsets.WoWPlayerMe.Name, Encoding.UTF8); }
        }

        /// <summary>
        /// The players GUID
        /// </summary>
        internal ulong TargetGUID
        {
            get { return ObjectManager.WoW.Read<ulong>((IntPtr)ObjectManager.WoW.ImageBase + (int)Offsets.WoWPlayerMe.TargetGUID); }
        }

        /// <summary>
        /// Returns the postion as Vector3
        /// </summary>
        internal Vector3 Position
        {
            get
            {
                return new Vector3{
                    X = ObjectManager.WoW.Read<float>((IntPtr)BaseAddress + (int)Offsets.WoWUnit.X),
                    Y = ObjectManager.WoW.Read<float>((IntPtr)BaseAddress + (int)Offsets.WoWUnit.Y),
                    Z = ObjectManager.WoW.Read<float>((IntPtr)BaseAddress + (int)Offsets.WoWUnit.Z)
                };
            }
        }

        /// <summary>
        /// The units rotation
        /// </summary>
        internal float Rotation
        {
            get
            {
                return ObjectManager.WoW.Read<float>((IntPtr)BaseAddress + (int)Offsets.WoWUnit.R);
            }
        }

        /// <summary>
        /// The continendid on which the player currently is
        /// </summary>
        internal int ContinentId
        {
            get {return ObjectManager.WoW.Read<int>((IntPtr)ObjectManager.WoW.ImageBase + (int) Offsets.WoWPlayerMe.ContinentId); }
        }

        /// <summary>
        /// The areaid on which the player currently is
        /// </summary>
        internal int AreaId
        {
            get { return ObjectManager.WoW.Read<int>((IntPtr)ObjectManager.WoW.ImageBase + (int) Offsets.WoWPlayerMe.AreaId); }
        }

        /// <summary>
        /// 
        /// </summary>
        internal string ZoneText
        {
            get { return ObjectManager.WoW.ReadString((IntPtr) ObjectManager.WoW.Read<uint>((IntPtr)ObjectManager.WoW.ImageBase + (int)Offsets.WoWPlayerMe.ZoneText), Encoding.ASCII); }
        }

        /// <summary>
        /// 
        /// </summary>
        internal string SubZoneText
        {
            get { return ObjectManager.WoW.ReadString((IntPtr) ObjectManager.WoW.Read<uint>((IntPtr)ObjectManager.WoW.ImageBase + (int)Offsets.WoWPlayerMe.SubZoneText), Encoding.ASCII); }
        }

        /// <summary>
        /// The players base health
        /// </summary>
        internal int BaseHealth
        {
            get { return GetDescriptorField<int>((uint)Offsets.WoWUnit.Health); }
        }

        /// <summary>
        /// The players max health
        /// </summary>
        internal int MaxHealth
        {
            get { return GetDescriptorField<int>((uint)Offsets.WoWUnit.MaxHealth); }
        }

        /// <summary>
        /// The players base power (Mana, Energy, Focus, Runic Power)
        /// </summary>
        internal int BasePower
        {
            get
            {
                int BasePower = 0;

                switch (this.Class)
                {
                    case WoWClass.Rogue:
                        BasePower = ObjectManager.WoW.Read<int>((IntPtr)DescriptorBase + (int)Offsets.WoWUnit.Energy);
                        break;
                    case WoWClass.Warrior:
                        BasePower = ObjectManager.WoW.Read<int>((IntPtr)DescriptorBase + (int)Offsets.WoWUnit.Energy);
                        break;
                    default:
                        BasePower = ObjectManager.WoW.Read<int>((IntPtr)DescriptorBase + (int)Offsets.WoWUnit.Power);
                        break;
                }

                return BasePower;
            }
        }

        /// <summary>
        /// The players max power (Mana, Energy, Focus, Runic Power)
        /// </summary>
        internal int MaxPower
        {
            get
            {
                int MaxPower = 0;

                switch (this.Class)
                {
                    default:
                        MaxPower = ObjectManager.WoW.Read<int>((IntPtr)DescriptorBase + (int)Offsets.WoWUnit.MaxPower);
                        break;
                }

                return MaxPower;
            }
        }

        /// <summary>
        /// The players combopoints
        /// </summary>
        internal int ComboPoints
        {
            get { return ObjectManager.WoW.Read<int>((IntPtr)ObjectManager.WoW.ImageBase + (int)Offsets.WoWPlayerMe.ComboPoints); }
        }

        /// <summary>
        /// The players current XP
        /// </summary>
        internal int XP
        {
            get { return GetDescriptorField<int>((uint)Offsets.WoWPlayerMe.XP); }
        }

        /// <summary>
        /// The players current XP
        /// </summary>
        internal int MaxXP
        {
            get { return GetDescriptorField<int>((uint)Offsets.WoWPlayerMe.NextLevelXP); }
        }

        /// <summary>
        /// The players class
        /// </summary>
        internal WoWClass Class
        {
            get
            {
                return (WoWClass)ObjectManager.WoW.Read<byte>((IntPtr) ObjectManager.WoW.ImageBase + (int)Offsets.WoWPlayerMe.PlayerClass);
            }
        }

        /// <summary>
        /// The players level
        /// </summary>
        internal float Level
        {
            get { return ObjectManager.WoW.Read<int>((IntPtr)DescriptorBase + (int)Offsets.WoWUnit.Level); }
        }
    }
}
