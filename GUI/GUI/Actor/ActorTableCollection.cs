﻿using GUI.Actor.Model;
using GUI.Memory;
using System;
using System.Collections;

namespace GUI.Actor
{
    public class ActorTableCollection : ICollection
    {
        private Game _game;
        private ActorEntry[] _currentEntries;

        public ActorTableCollection(Game game)
        {
            _game = game;
        }

        public void Update()
        {
            var numEntries =
                _game.Process.ReadUInt64(
                    _game.Process.GetModuleBasedOffset("ffxiv_dx11.exe", _game.Definitions.ActorTable));

            _currentEntries = new ActorEntry[numEntries];

            for (ulong i = 0; i < numEntries; i++)
            {
                ulong offset = 8 + (i * 8);

                var address = new Pointer(_game.Process, _game.Definitions.ActorTable + offset, 0);

                _currentEntries[i] = new ActorEntry
                {
                    Offset = address,
                    ActorID = _game.Process.ReadUInt32(address + _game.Definitions.ActorID),
                    Name = _game.Process.ReadString(address + _game.Definitions.Name),
                    DataId = _game.Process.ReadUInt32(address + _game.Definitions.BnpcBase),
                    OwnerID = _game.Process.ReadUInt32(address + _game.Definitions.OwnerID),
                    ModelChara = _game.Process.ReadUInt16(address + _game.Definitions.ModelChara),
                    Job = _game.Process.ReadByte(address + _game.Definitions.Job),
                    Level = _game.Process.ReadByte(address + _game.Definitions.Level),
                    World = _game.Process.ReadByte(address + _game.Definitions.World),
                    CompanyTag = _game.Process.ReadString(address + _game.Definitions.CompanyTag),
                    ObjectKind = (ObjectKind)_game.Process.ReadByte(address + _game.Definitions.ObjectKind),
                    SubKind = _game.Process.ReadByte(address + _game.Definitions.SubKind),
                    location = new Datatypes.Vector3(_game.Process.ReadFloat(address + _game.Definitions.PositionX), _game.Process.ReadFloat(address + _game.Definitions.PositionY), _game.Process.ReadFloat(address + _game.Definitions.PositionZ)),

                    Appearance = new ActorAppearance()
                    {
                        Customize = _game.Process.ReadBytes(address + _game.Definitions.Customize, 26),
                    }
                };
            }
        }

        public ActorEntry this[int i] => _currentEntries[i];

        public IEnumerator GetEnumerator()
        {
            return _currentEntries.GetEnumerator();
        }

        int ICollection.Count => _currentEntries?.Length ?? 0;

        void ICollection.CopyTo(Array array, int index)
        {
            foreach (var entry in _currentEntries)
            {
                array.SetValue(entry, index);
                index++;
            }
        }

        bool ICollection.IsSynchronized => false;

        object ICollection.SyncRoot => this;
    }
}