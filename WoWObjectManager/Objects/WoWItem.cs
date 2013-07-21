/*
 * This file is part of the WoWObjectManager (C) 2013 Finn Grimpe
 * Copyright 2013 Finn Grimpe, All Rights Reserved
 * 
 * Github:  https://github.com/finndev/WoWObjectManager/
 * Website: http://finn.lu/
 * License: http://finn.lu/license
 *
 */

using System.Collections.Specialized;

namespace WoWObjectManager.Objects
{
    /// <summary>
    /// A WoWitem
    /// </summary>
    class WoWItem : WoWObject
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="BaseAddress"></param>
        public WoWItem(uint BaseAddress)
            : base(BaseAddress) { }

        /// <summary>
        /// The items owner GUID
        /// </summary>
        internal ulong Owner
        {
            get { return GetDescriptorField<ulong>((uint)Offsets.WoWItem.Owner); }
        }

        /// <summary>
        /// The items durability
        /// </summary>
        internal int Durability
        {
            get { return GetDescriptorField<int>((uint)Offsets.WoWItem.Durability); }
        }

        /// <summary>
        /// The items maximum durability
        /// </summary>
        internal int MaxDurability
        {
            get { return GetDescriptorField<int>((uint)Offsets.WoWItem.MaxDurability); }
        }

        /// <summary>
        /// The amount of stacks
        /// </summary>
        internal int StackCount
        {
            get { return GetDescriptorField<int>((uint)Offsets.WoWItem.StackCount); }
        }

        /// <summary>
        /// The amount of charges this item has left
        /// </summary>
        internal int Charges
        {
            get { return GetDescriptorField<int>((uint)Offsets.WoWItem.SpellCharges); }
        }

        /// <summary>
        /// The durability of this item in percent
        /// </summary>
        internal float DurabilityPercent
        {
            get
            {
                if (Durability <= 0 || MaxDurability <= 0) return 0f; 
                return ((MaxDurability * 100) / Durability);
            }
        }

        /// <summary>
        /// The GUID in which the item is contained
        /// </summary>
        internal ulong ContainedIn
        {
            get { return GetDescriptorField<ulong>((uint)Offsets.WoWItem.ContainedIn); }
        }

        /// <summary>
        /// Checks whether the item has that item flag or not
        /// </summary>
        /// <param name="flag">The ItemFlag</param>
        /// <returns>true or false</returns>
        internal bool HasFlag(Offsets.WoWItemFlags flag)
        {
            return DynamicFlags[(int)flag];
        }

        /// <summary>
        /// The items dynamic flags
        /// </summary>
        internal BitVector32 DynamicFlags
        {
            get { return GetDescriptorField<BitVector32>((uint)Offsets.WoWItem.DynamicFlags); }
        }
    }
}
