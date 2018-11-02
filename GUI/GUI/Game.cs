using GUI.Actor;
using GUI.Memory;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public partial class Game
    {
        public enum GameType
        {
            Dx9,
            Dx11
        }

        public readonly GameType Type;
        public readonly string Version;
        public readonly CustomProcess Process;
        public readonly Definitions Definitions;

        public readonly ActorTableCollection ActorTable;

        public Game(Process process)
        {
            Type = process.MainModule.ModuleName.Contains("ffxiv_dx11") ? GameType.Dx11 : GameType.Dx9;
            Process = process.GetNhaamaProcess();

            var gameDirectory = new DirectoryInfo(process.MainModule.FileName);
            Version = File.ReadAllText(Path.Combine(gameDirectory.Parent.FullName, "ffxivgame.ver"));

            Definitions = Definitions.Get(Process, Version, Type);

            ActorTable = new ActorTableCollection(this);
        }

        /// <summary>
        /// Update game data.
        /// </summary>
        public void Update()
        {
            ActorTable.Update();
        }
    }
}
