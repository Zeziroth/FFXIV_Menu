﻿namespace GUI.Actor.Model
{
    public enum ObjectKind : byte
    {
        None = 0x00,
        Player = 0x01,
        BattleNpc = 0x02,
        EventNpc = 0x03,
        Treasure = 0x04,
        Aetheryte = 0x05,
        GatheringPoint = 0x06,
        EventObj = 0x07,
        MountType = 0x08,
        Companion = 0x09, // Minion
        Retainer = 0x0A,
        Area = 0x0B,
        Housing = 0x0C,
        Cutscene = 0x0D,
        CardStand = 0x0E,
    }
}
