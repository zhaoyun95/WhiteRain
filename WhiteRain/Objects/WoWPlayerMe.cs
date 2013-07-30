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
using System.Text;

namespace WhiteRainNS.Objects
{
    /// <summary>
    /// Repesents the local player
    /// </summary>
    public class WoWPlayerMe : WoWUnit
    {
        public WoWPlayerMe(IntPtr BaseAddress)
            : base(BaseAddress) { }

        /// <summary>
        /// The players name
        /// </summary>
        public string Name
        {
            get { return WhiteRain.WoW.ReadString((IntPtr) WhiteRain.WoW.ImageBase + (int)Offsets.WoWPlayerMe.Name, Encoding.UTF8); }
        }

        /// <summary>
        /// The players GUID
        /// </summary>
        public ulong TargetGUID
        {
            get { return WhiteRain.WoW.Read<ulong>((IntPtr)WhiteRain.WoW.ImageBase + (int)Offsets.WoWPlayerMe.TargetGUID); }
        }

        /// <summary>
        /// Returns the postion as Vector3
        /// </summary>
        public Vector3 Position
        {
            get
            {
                return new Vector3{
                    X = WhiteRain.WoW.Read<float>((IntPtr)BaseAddress + (int)Offsets.WoWUnit.X),
                    Y = WhiteRain.WoW.Read<float>((IntPtr)BaseAddress + (int)Offsets.WoWUnit.Y),
                    Z = WhiteRain.WoW.Read<float>((IntPtr)BaseAddress + (int)Offsets.WoWUnit.Z)
                };
            }
        }

        /// <summary>
        /// The units rotation
        /// </summary>
        public float Rotation
        {
            get
            {
                return WhiteRain.WoW.Read<float>((IntPtr)BaseAddress + (int)Offsets.WoWUnit.R);
            }
        }

        /// <summary>
        /// The continendid on which the player currently is
        /// </summary>
        public int ContinentId
        {
            get {return WhiteRain.WoW.Read<int>((IntPtr)WhiteRain.WoW.ImageBase + (int) Offsets.WoWPlayerMe.ContinentId); }
        }

        /// <summary>
        /// The areaid on which the player currently is
        /// </summary>
        public int AreaId
        {
            get { return WhiteRain.WoW.Read<int>((IntPtr)WhiteRain.WoW.ImageBase + (int) Offsets.WoWPlayerMe.AreaId); }
        }

        /// <summary>
        /// 
        /// </summary>
        public string ZoneText
        {
            get { return WhiteRain.WoW.ReadString((IntPtr) WhiteRain.WoW.Read<uint>((IntPtr)WhiteRain.WoW.ImageBase + (int)Offsets.WoWPlayerMe.ZoneText), Encoding.ASCII); }
        }

        /// <summary>
        /// 
        /// </summary>
        public string SubZoneText
        {
            get { return WhiteRain.WoW.ReadString((IntPtr) WhiteRain.WoW.Read<uint>((IntPtr)WhiteRain.WoW.ImageBase + (int)Offsets.WoWPlayerMe.SubZoneText), Encoding.ASCII); }
        }

        /// <summary>
        /// The players base health
        /// </summary>
        public int BaseHealth
        {
            get { return GetDescriptorField<int>((uint)Offsets.WoWUnit.Health); }
        }

        /// <summary>
        /// The players max health
        /// </summary>
        public int MaxHealth
        {
            get { return GetDescriptorField<int>((uint)Offsets.WoWUnit.MaxHealth); }
        }

        /// <summary>
        /// The players base power (Mana, Energy, Focus, Runic Power)
        /// </summary>
        public int BasePower
        {
            get
            {
                int BasePower = 0;

                switch (this.Class)
                {
                    case WoWClass.Rogue:
                        BasePower = WhiteRain.WoW.Read<int>((IntPtr)DescriptorBase + (int)Offsets.WoWUnit.Energy);
                        break;
                    case WoWClass.Warrior:
                        BasePower = WhiteRain.WoW.Read<int>((IntPtr)DescriptorBase + (int)Offsets.WoWUnit.Energy);
                        break;
                    default:
                        BasePower = WhiteRain.WoW.Read<int>((IntPtr)DescriptorBase + (int)Offsets.WoWUnit.Power);
                        break;
                }

                return BasePower;
            }
        }

        /// <summary>
        /// The players max power (Mana, Energy, Focus, Runic Power)
        /// </summary>
        public int MaxPower
        {
            get
            {
                int MaxPower = 0;

                switch (this.Class)
                {
                    default:
                        MaxPower = WhiteRain.WoW.Read<int>((IntPtr)DescriptorBase + (int)Offsets.WoWUnit.MaxPower);
                        break;
                }

                return MaxPower;
            }
        }

        /// <summary>
        /// The players combopoints
        /// </summary>
        public int ComboPoints
        {
            get { return WhiteRain.WoW.Read<int>((IntPtr)WhiteRain.WoW.ImageBase + (int)Offsets.WoWPlayerMe.ComboPoints); }
        }

        /// <summary>
        /// The players current XP
        /// </summary>
        public int XP
        {
            get { return GetDescriptorField<int>((uint)Offsets.WoWPlayerMe.XP); }
        }

        /// <summary>
        /// The players current XP
        /// </summary>
        public int MaxXP
        {
            get { return GetDescriptorField<int>((uint)Offsets.WoWPlayerMe.NextLevelXP); }
        }

        /// <summary>
        /// The players class
        /// </summary>
        public WoWClass Class
        {
            get
            {
                return (WoWClass)WhiteRain.WoW.Read<byte>((IntPtr) WhiteRain.WoW.ImageBase + (int)Offsets.WoWPlayerMe.PlayerClass);
            }
        }

        /// <summary>
        /// The players level
        /// </summary>
        public float Level
        {
            get { return WhiteRain.WoW.Read<int>((IntPtr)DescriptorBase + (int)Offsets.WoWUnit.Level); }
        }
    }
}
