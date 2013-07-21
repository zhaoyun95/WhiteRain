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

namespace WoWObjectManager.Objects
{
    /// <summary>
    /// Repesents the local player
    /// </summary>
    class WoWPlayerMe : WoWObject
    {
        internal WoWPlayerMe(uint BaseAddress)
            : base(BaseAddress) { }

        /// <summary>
        /// The players name
        /// </summary>
        internal string Name
        {
            get { return ObjectManager.WoW.ReadASCIIString((uint) ObjectManager.WoW.MainModule.BaseAddress + (int) Offsets.WoWPlayerMe.Name, 128); }
        }

        /// <summary>
        /// The players GUID
        /// </summary>
        internal ulong TargetGUID
        {
            get { return ObjectManager.WoW.ReadUInt64((uint)ObjectManager.WoW.MainModule.BaseAddress + (int)Offsets.WoWPlayerMe.TargetGUID); }
        }

        /// <summary>
        /// Returns the postion as Vector3
        /// </summary>
        internal Vector3 Position
        {
            get
            {
                return new Vector3(
                    ObjectManager.WoW.ReadFloat(BaseAddress + (int)Offsets.WoWUnit.X),
                    ObjectManager.WoW.ReadFloat(BaseAddress + (int)Offsets.WoWUnit.Y),
                    ObjectManager.WoW.ReadFloat(BaseAddress + (int)Offsets.WoWUnit.Z)
                    );
            }
        }

        /// <summary>
        /// The continendid on which the player currently is
        /// </summary>
        internal int ContinentId
        {
            get {return ObjectManager.WoW.ReadInt((uint)ObjectManager.WoW.MainModule.BaseAddress + (int) Offsets.WoWPlayerMe.ContinentId); }
        }

        /// <summary>
        /// The areaid on which the player currently is
        /// </summary>
        internal int AreaId
        {
            get { return ObjectManager.WoW.ReadInt((uint)ObjectManager.WoW.MainModule.BaseAddress + (int) Offsets.WoWPlayerMe.AreaId); }
        }

        /// <summary>
        /// 
        /// </summary>
        internal string ZoneText
        {
            get { return ObjectManager.WoW.ReadASCIIString(ObjectManager.WoW.ReadUInt((uint)ObjectManager.WoW.MainModule.BaseAddress + (int)Offsets.WoWPlayerMe.ZoneText), 128); }
        }

        /// <summary>
        /// 
        /// </summary>
        internal string SubZoneText
        {
            get { return ObjectManager.WoW.ReadASCIIString(ObjectManager.WoW.ReadUInt((uint)ObjectManager.WoW.MainModule.BaseAddress + (int)Offsets.WoWPlayerMe.SubZoneText), 128); }
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
        /// The players base power
        /// </summary>
        internal float BasePower
        {
            get { return ObjectManager.WoW.ReadInt((uint)DescriptorBase + (int)Offsets.WoWUnit.Power); }
        }

        /// <summary>
        /// The players max power
        /// </summary>
        internal float MaxPower
        {
            get { return ObjectManager.WoW.ReadInt((uint)DescriptorBase + (int)Offsets.WoWUnit.MaxPower); }
        }

        /// <summary>
        /// The players combopoints
        /// </summary>
        internal int ComboPoints
        {
            get { return ObjectManager.WoW.ReadInt((uint)ObjectManager.WoW.MainModule.BaseAddress + (int)Offsets.WoWPlayerMe.ComboPoints); }
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
                return (WoWClass)ObjectManager.WoW.ReadByte((uint)ObjectManager.WoW.MainModule.BaseAddress + (int)Offsets.WoWPlayerMe.PlayerClass);
            }
        }

        /// <summary>
        /// The players level
        /// </summary>
        internal float Level
        {
            get { return ObjectManager.WoW.ReadInt((uint)DescriptorBase + (int)Offsets.WoWUnit.Level); }
        }

        /// <summary>
        /// Returns whether the player is alive or not.
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
    }
}
