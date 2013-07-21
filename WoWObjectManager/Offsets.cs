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
namespace WoWObjectManager
{
    /// <summary>
    /// All offsets are for patch 5.3.0 17055.
    /// Credits to the OwnedCore.com Memory section (http://www.ownedcore.com/forums/world-of-warcraft/world-of-warcraft-bots-programs/wow-memory-editing/)
    /// </summary>
    class Offsets
    {
        public enum General
        {
            WoWVersion = 0xC01497
        }

        public enum ObjectManager
        {
            clientConnection = 0xE3CB00,
            ObjectManager = 0x462C,
            FirstObject = 0xCC,
            NextObject = 0x34,
            LocalGUID = 0xE0
        }

        public enum Descriptors
        {
            Descriptor = 0x4,
            Level = 0xD0,
            DisplayId = 0x108
        }

        public enum WoWObject
        {
            Type = 0xC,
            GUID = 0x28,
            DynamicFlags = 0x18,
        }

        public enum WoWCorpse
        {
            Owner = 0x20,
            PartyGUID = 0x28,
            DisplayID = 0x30,
            Items = 0x34,
            SkinID = 0x80,
            FacialHairStyleID = 0x84,
            Flags = 0x88,
            DynamicFlags = 0x8C,

            Player_Corpse_X = 0xCDCC00,
            Player_Corpse_Y = Player_Corpse_X + 0x4,
            Player_Corpse_Z = Player_Corpse_Y + 0x4
        }

        public enum WoWPlayerMe
        {
            Name = 0xE3CB40,
            GUID = 0xC8A7B0,
            TargetGUID = 0xCDC878,
            MouseOverGUID = 0xD50F38,
            ComboPoints = 0xD51009,
            PetGUID = 0xDBF660,
            PlayerClass = 0xE3CCBD,
            ContinentId = 0xA5E814,
            AreaId = 0xADFA68,
            ZoneText = 0xCDC844, //Orgrimmar
            SubZoneText = 0xCDC840, //The valley of honor
            DuelArbiter = 0x26C,
            PlayerFlags = 0x274,
            GuildRankID = 0x278,
            GuildDeleteDate = 0x27C,
            GuildLevel = 0x280,
            HairColorID = 0x284,
            RestState = 0x288,
            ArenaFaction = 0x28C,
            DuelTeam = 0x290,
            GuildTimeStamp = 0x294,
            QuestLog = 0x298,
            VisibleItems = 0xE50,
            PlayerTitle = 0xEE8,
            FakeInebriation = 0xEEC,
            VirtualPlayerRealm = 0xEF0,
            CurrentSpecID = 0xEF4,
            TaxiMountAnimKitID = 0xEF8,
            CurrentBattlePetBreedQuality = 0xEFC,
            InvSlots = 0xF00,
            FarsightObject = 0x11B0,
            KnownTitles = 0x11B8,
            Coinage = 0x11D8,
            XP = 0x11E0,
            NextLevelXP = 0x11E4,
            Skill = 0x11E8,
            CharacterPoints = 0x18E8,
            MaxTalentTiers = 0x18EC,
            TrackCreatureMask = 0x18F0,
            TrackResourceMask = 0x18F4,
            MainhandExpertise = 0x18F8,
            OffhandExpertise = 0x18FC,
            RangedExpertise = 0x1900,
            CombatRatingExpertise = 0x1904,
            BlockPercentage = 0x1908,
            DodgePercentage = 0x190C,
            ParryPercentage = 0x1910,
            CritPercentage = 0x1914,
            RangedCritPercentage = 0x1918,
            OffhandCritPercentage = 0x191C,
            SpellCritPercentage = 0x1920,
            ShieldBlock = 0x193C,
            ShieldBlockCritPercentage = 0x1940,
            Mastery = 0x1944,
            PvpPowerDamage = 0x1948,
            PvpPowerHealing = 0x194C,
            ExploredZones = 0x1950,
            RestStateBonusPool = 0x1C70,
            ModDamageDonePos = 0x1C74,
            ModDamageDoneNeg = 0x1C90,
            ModDamageDonePercent = 0x1CAC,
            ModHealingDonePos = 0x1CC8,
            ModHealingPercent = 0x1CCC,
            ModHealingDonePercent = 0x1CD0,
            ModPeriodicHealingDonePercent = 0x1CD4,
            WeaponDmgMultipliers = 0x1CD8,
            ModSpellPowerPercent = 0x1CE4,
            ModResiliencePercent = 0x1CE8,
            OverrideSpellPowerByAPPercent = 0x1CEC,
            OverrideAPBySpellPowerPercent = 0x1CF0,
            ModTargetResistance = 0x1CF4,
            ModTargetPhysicalResistance = 0x1CF8,
            LifetimeMaxRank = 0x1CFC,
            SelfResSpell = 0x1D00,
            PvpMedals = 0x1D04,
            BuybackPrice = 0x1D08,
            BuybackTimestamp = 0x1D38,
            YesterdayHonorableKills = 0x1D68,
            LifetimeHonorableKills = 0x1D6C,
            WatchedFactionIndex = 0x1D70,
            CombatRatings = 0x1D74,
            ArenaTeams = 0x1DE0,
            BattlegroundRating = 0x1E34,
            MaxLevel = 0x1E38,
            RuneRegen = 0x1E3C,
            NoReagentCostMask = 0x1E4C,
            GlyphSlots = 0x1E5C,
            Glyphs = 0x1E74,
            GlyphSlotsEnabled = 0x1E8C,
            PetSpellPower = 0x1E90,
            Researching = 0x1E94,
            ProfessionSkillLine = 0x1EB4,
            UiHitModifier = 0x1EBC,
            UiSpellHitModifier = 0x1EC0,
            HomeRealmTimeOffset = 0x1EC4,
            ModRangedHaste = 0x1EC8,
            ModPetHaste = 0x1ECC,
            SummonedBattlePetGUID = 0x1ED0,
            OverrideSpellsID = 0x1ED8,
            LfgBonusFactionID = 0x1EDC,
            LootSpecID = 0x1EE0,
            OverrideZonePVPType = 0x1EE4,
            ItemLevelDelta = 0x1EE8
        }

        public enum WoWItem
        {
            Owner = 0x20,
            ContainedIn = 0x28,
            Creator = 0x30,
            GiftCreator = 0x38,
            StackCount = 0x40,
            Expiration = 0x44,
            SpellCharges = 0x48,
            DynamicFlags = 0x5C,
            Enchantment = 0x60,
            PropertySeed = 0xFC,
            RandomPropertiesID = 0x100,
            Durability = 0x104,
            MaxDurability = 0x108,
            CreatePlayedTime = 0x10C,
            ModifiersMask = 0x110,
        }

        public enum WoWUnit
        {
            NamePointer = 0x974,
            NameOffset = 0x6C,
            X = 0x7F8,
            Y = X + 0x4,
            Z = Y + 0x4,
            Charm = 0x20,
            Summon = 0x28,
            Critter = 0x30,
            CharmedBy = 0x38,
            SummonedBy = 0x40,
            CreatedBy = 0x48,
            Target = 0x50,
            BattlePetCompanionGUID = 0x58,
            ChannelObject = 0x60,
            ChannelSpell = 0x68,
            SummonedByHomeRealm = 0x6C,
            DisplayPower = 0x70,
            OverrideDisplayPowerID = 0x74,
            Health = 0x78,
            Power = 0x7C,
            MaxHealth = 0x90,
            MaxPower = 0x94,
            PowerRegenFlatModifier = 0xA8,
            PowerRegenInterruptedFlatModifier = 0xBC,
            Level = 0xD0,
            EffectiveLevel = 0xD4,
            FactionTemplate = 0xD8,
            VirtualItemID = 0xDC,
            Flags = 0xE8,
            Flags2 = 0xEC,
            AuraState = 0xF0,
            AttackRoundBaseTime = 0xF4,
            RangedAttackRoundBaseTime = 0xFC,
            BoundingRadius = 0x100,
            CombatReach = 0x104,
            DisplayID = 0x108,
            NativeDisplayID = 0x10C,
            MountDisplayID = 0x110,
            MinDamage = 0x114,
            MaxDamage = 0x118,
            MinOffHandDamage = 0x11C,
            MaxOffHandDamage = 0x120,
            AnimTier = 0x124,
            PetNumber = 0x128,
            PetNameTimestamp = 0x12C,
            PetExperience = 0x130,
            PetNextLevelExperience = 0x134,
            ModCastingSpeed = 0x138,
            ModSpellHaste = 0x13C,
            ModHaste = 0x140,
            ModHasteRegen = 0x144,
            CreatedBySpell = 0x148,
            NpcFlags = 0x14C,
            EmoteState = 0x154,
            Stats = 0x158,
            StatPosBuff = 0x16C,
            StatNegBuff = 0x180,
            Resistances = 0x194,
            ResistanceBuffModsPositive = 0x1B0,
            ResistanceBuffModsNegative = 0x1CC,
            BaseMana = 0x1E8,
            BaseHealth = 0x1EC,
            ShapeshiftForm = 0x1F0,
            AttackPower = 0x1F4,
            AttackPowerModPos = 0x1F8,
            AttackPowerModNeg = 0x1FC,
            AttackPowerMultiplier = 0x200,
            RangedAttackPower = 0x204,
            RangedAttackPowerModPos = 0x208,
            RangedAttackPowerModNeg = 0x20C,
            RangedAttackPowerMultiplier = 0x210,
            MinRangedDamage = 0x214,
            MaxRangedDamage = 0x218,
            PowerCostModifier = 0x21C,
            PowerCostMultiplier = 0x238,
            MaxHealthModifier = 0x254,
            HoverHeight = 0x258,
            MinItemLevel = 0x25C,
            MaxItemLevel = 0x260,
            WildBattlePetLevel = 0x264,
            BattlePetCompanionNameTimestamp = 0x268,
        }

        [Flags]
        public enum WoWItemFlags : uint
        {
            ItemFlagNone = 0x0,
            ItemFlagSoulbound = 0x1,
            ItemFlagConjured = 0x2,
            ItemFlagLootable = 0x4,
            ItemFlagWrapGift = 0x200,
            ItemFlagCreateItem = 0x400,
            ItemFlagQuest = 0x800,
            ItemFlagRefundable = 0x1000,
            ItemFlagSignable = 0x2000,
            ItemFlagReadable = 0x4000,
            ItemFlagEventReq = 0x10000,
            ItemFlagProspectable = 0x40000,
            ItemFlagUniqueEquip = 0x80000,
            ItemFlagThrown = 0x400000,
            ItemFlagShapeshiftOK = 0x800000,
            ItemFlagAccountBound = 0x8000000,
            ItemFlagMillable = 0x20000000
        }

        [Flags]
        public enum UnitFlags : uint
        {
            None = 0,
            Sitting = 0x1,
            Influenced = 0x4,
            PlayerControlled = 0x8,
            Totem = 0x10,
            Preparation = 0x20,
            PlusMob = 0x40,
            NotAttackable = 0x100,
            Looting = 0x400,
            PetInCombat = 0x800,
            PvPFlagged = 0x1000,
            Silenced = 0x2000,
            Pacified = 0x20000,
            Stunned = 0x40000,
            CanPerformAction_Mask1 = 0x60000,
            Combat = 0x80000,
            TaxiFlight = 0x100000,
            Disarmed = 0x200000,
            Confused = 0x400000,
            Fleeing = 0x800000,
            Possessed = 0x1000000,
            NotSelectable = 0x2000000,
            Skinnable = 0x4000000,
            Mounted = 0x8000000,
            Dazed = 0x20000000,
            Sheathe = 0x40000000,
        }

        [Flags]
        public enum UnitDynamicFlags
        {
            None = 0,
            Lootable = 0x1,
            TrackUnit = 0x2,
            TaggedByOther = 0x4,
            TaggedByMe = 0x8,
            SpecialInfo = 0x10,
            Dead = 0x20,
            ReferAFriendLinked = 0x40,
            IsTappedByAllThreatList = 0x80,
        }

        [Flags]
        public enum WoWNpcFlags : uint
        {
            None = 0,
            Gossip = 0x1,
            QuestGiver = 0x2,
            CanTrain = 0x10,
            BattlePetTrainer = 0x20,
            DailyQuests = 0x40,
            CanSell = 0x80,
            SellsFood = 0x200,
            Reagents = 0x800,
            CanRepair = 0x1000,
            Taxi = 0x2000,
            Innkeeper = 0x10000,
            Banker = 0x20000,
            Auctioneer = 0x200000,
            StableMaster = 0x400000,
            GuildBanker = 0x800000,
            MailInfo = 0x4000000,
            ForgeMaster = 0x8000000,
            Transmogrifier = 0x10000000,
            VoidStorageBanker = 0x20000000,
        }
    }

    //Special thanks to Apoc.
    public enum WoWClass
    {
        None = 0,
        Warrior = 1,
        Paladin = 2,
        Hunter = 3,
        Rogue = 4,
        Priest = 5,
        DeathKnight = 6,
        Shaman = 7,
        Mage = 8,
        Warlock = 9,
        Druid = 11,
    }

    public enum WoWObjectType
    {
        Item = 1,
        Container = 2,
        Unit = 3,
        Player = 4,
        GameObject = 5,
        DynamicObject = 6,
        Corpse = 7,
        AiGroup = 8,
        AreaTrigger = 9
    }

    public class Vector3
    {
        internal float X { get; set; }
        internal float Y { get; set; }
        internal float Z { get; set; }

        public Vector3(float X, float Y, float Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }
    }
}
