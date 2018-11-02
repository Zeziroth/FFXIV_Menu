﻿using GUI.Memory;
using Newtonsoft.Json;
using System;
using System.Net;

namespace GUI
{
    public class Definitions
    {
        private Definitions(CustomProcess process)
        {
            TerritoryType = new Pointer(process, 0x19D55E8, 0x4C);
            Time = new Pointer(process, 0x19815F0, 0x10, 0x8, 0x28, 0x80);
            Weather = new Pointer(process, 0x19579A8, 0x27);
        }

        [JsonConstructor]
        private Definitions() { }

        public Pointer TerritoryType;
        public Pointer Time;
        public Pointer Weather;

        public ulong ActorTable = 0x199DA38;

        public ulong ActorID = 0x74;
        public ulong Name = 0x30;
        public ulong BnpcBase = 0x80;
        public ulong OwnerID = 0x84;
        public ulong ModelChara = 0x16FC;
        public ulong Job = 0x1788;
        public ulong Level = 0x178A;
        public ulong World = 0x1744;
        public ulong CompanyTag = 0x16A2;
        public ulong Customize = 0x1688;
        public ulong RenderMode = 0x104;
        public ulong ObjectKind = 0x8C;
        public ulong SubKind = 0x8D;

        public ulong Head = 0x15E8;
        public ulong Body = 0x15EC;
        public ulong Hands = 0x15F0;
        public ulong Legs = 0x15F4;
        public ulong Feet = 0x15F8;
        public ulong Ear = 0x15FC;
        public ulong Neck = 0x1600;
        public ulong Wrist = 0x1604;
        public ulong RRing = 0x1608;
        public ulong LRing = 0x160C;

        public ulong MainWep = 0x1342;
        public ulong OffWep = 0x13A8;

        private static readonly Uri DefinitionStoreUrl = new Uri("https://raw.githubusercontent.com/goaaats/Nhaama/master/definitions/FFXIV/");

        public static Definitions Get(CustomProcess p, string version, Game.GameType gameType)
        {
            using (WebClient client = new WebClient())
            {
                var uri = new Uri(DefinitionStoreUrl, $"https://raw.githubusercontent.com/goaaats/Nhaama/master/definitions/FFXIV/dx11/2018.09.27.0000.0000.json");

                try
                {
                    var definitionJson = client.DownloadString(uri);
                    var serializer = p.GetSerializer();
                    var deserializedDefinition = serializer.DeserializeObject<Definitions>(definitionJson);

                    return deserializedDefinition;
                }
                catch (WebException exc)
                {
                    throw new Exception("Could not get definitions for version: " + uri, exc);
                }
            }
        }

        public static string GetJson(CustomProcess process)
        {
            var serializer = process.GetSerializer();

            return serializer.SerializeObject(new Definitions(process), Newtonsoft.Json.Formatting.Indented);
        }
    }
}
