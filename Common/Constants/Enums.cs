﻿using System;

namespace Common.Constants
{
    public enum Expansions : int
    {
        PreRelease,
        Vanilla,
        TBC,
        WotLK,
        Cata,
        MoP,
        WoD,
        Legion,
        BfA, 
        Shadowlands,
        Dragonflight
    }

    public enum Classes : byte
    {
        WARRIOR = 1,
        PALADIN = 2,
        HUNTER = 3,
        ROGUE = 4,
        PRIEST = 5,
        DEATHKNIGHT = 6,
        SHAMAN = 7,
        MAGE = 8,
        WARLOCK = 9,
        MONK = 10,
        DRUID = 11
    }

    public enum Races : byte
    {
        HUMAN = 1,
        ORC = 2,
        DWARF = 3,
        NIGHT_ELF = 4,
        UNDEAD = 5,
        TAUREN = 6,
        GNOME = 7,
        TROLL = 8,
        GOBLIN = 9,
        BLOODELF = 10,
        DRAENEI = 11,
        WORGEN = 22,
        HUMAN_GILNEAN = 23,
        PANDAREN_NEUTRAL = 24,
        PANDAREN_ALLI = 25,
        PANDAREN_HORDE = 26
    }

    public enum PowerTypes : uint
    {
        MANA = 0,
        RAGE = 1,
        FOCUS = 2,
        ENERGY = 3,
        HAPPINESS = 4,
        RUNES = 5,
        RUNIC = 6,
        POWER_HEALTH = 0xFFFFFFFE
    }

    public enum StandState : uint
    {
        STANDING = 0x0,
        SITTING = 0x1,
        SITTINGCHAIR = 0x2,
        SLEEPING = 0x3,
        SITTINGCHAIRLOW = 0x4,
        FIRSTCHAIRSIT = 0x4,
        SITTINGCHAIRMEDIUM = 0x5,
        SITTINGCHAIRHIGH = 0x6,
        LASTCHAIRSIT = 0x6,
        DEAD = 0x7,
        KNEEL = 0x8,
    };

    public enum RealmlistOpcodes : byte
    {
        LOGON_CHALLENGE = 0,
        LOGON_PROOF = 1,
        RECONNECT_CHALLENGE = 2,
        RECONNECT_PROOF = 3,
        REALMLIST_REQUEST = 16,
    }

    [Flags]
    public enum AccountDataMask : byte
    {
        GLOBAL_CONFIG_CACHE = 0x1,
        CHARACTER_CONFIG_CACHE = 0x2,
        GLOBAL_BINDINGS_CACHE = 0x4,
        CHARACTER_BINDINGS_CACHE = 0x8,
        GLOBAL_MACROS_CACHE = 0x10,
        CHARACTER_MACROS_CACHE = 0x20,
        CHARACTER_LAYOUT_CACHE = 0x40,
        CHARACTER_CHAT_CACHE = 0x80,
        //
        GLOBAL = GLOBAL_BINDINGS_CACHE | GLOBAL_CONFIG_CACHE | GLOBAL_MACROS_CACHE,
        CHARACTER = CHARACTER_CONFIG_CACHE | CHARACTER_BINDINGS_CACHE | CHARACTER_MACROS_CACHE | CHARACTER_LAYOUT_CACHE | CHARACTER_CHAT_CACHE,
        ALL = GLOBAL | CHARACTER
    }

    public enum SpeedType : byte
    {
        Run,
        Swim,
        Fly,
    }
}
