using GUI.Actor.Model;
using GUI.Datatypes;
using GUI.Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        CustomProcess proc = Process.GetProcessesByName("ffxiv_dx11")[0].GetNhaamaProcess();

        Game xivgame = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            xivgame = new Game(proc.BaseProcess);
            Core.RunThread(ScanActors);
        }

        private void ScanActors()
        {
            while (true)
            {
                if (checkBox_Playerlist.Checked)
                {
                    Invoker.ClearList(listView_Player);
                }

                if (checkBox_NPCList.Checked)
                {
                    Invoker.ClearList(listView_NPC);
                }
                if (checkBox_MobList.Checked)
                {
                    Invoker.ClearList(listView_Mobs);
                }
                if (checkBox_EntityList.Checked)
                {
                    Invoker.ClearList(listView_Entities);
                }
                xivgame.Update();
                

                foreach (var entity in xivgame.ActorTable.Cast<ActorEntry>())
                {
                    Vector3 mainPos = xivgame.ActorTable[0].location;
                    ListViewItem itm = new ListViewItem(new string[] { entity.Name,  entity.Level.ToString(), Math.Round(mainPos.DistanceTo(entity.location),1).ToString() + "m"}, 0, Color.Red, listView_Player.BackColor, listView_Player.Font);
                    itm.Tag = entity.location;

                    switch (entity.ObjectKind)
                    {
                        case ObjectKind.Player:
                            if (checkBox_Playerlist.Checked)
                            {
                                Invoker.AddListItem(listView_Player, itm);
                            }
                            break;

                        case ObjectKind.EventObj:
                        case ObjectKind.EventNpc:
                            if (checkBox_NPCList.Checked)
                            {
                                Invoker.AddListItem(listView_NPC, itm);
                            }
                            break;

                        case ObjectKind.BattleNpc:
                            if (checkBox_MobList.Checked)
                            {
                                Invoker.AddListItem(listView_Mobs, itm);
                            }
                            break;
                        case ObjectKind.Companion:

                            break;
                        default:
                            if (checkBox_EntityList.Checked)
                            {
                                Invoker.AddListItem(listView_Entities, itm);
                            }
                            break;
                    }



                }

                Thread.Sleep(2500);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Core.CloseThreads();
        }

        private void tPHereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem item = (sender as ToolStripItem);
            if (item != null)
            {
                ContextMenuStrip owner = item.Owner as ContextMenuStrip;
                ListView list = owner.SourceControl as ListView;

                Teleport_ListView(list);
            }
        }

        private void listView_Player_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Teleport_ListView((ListView) sender);
        }

        private void Teleport_ListView(ListView list)
        {
            if (list.SelectedItems.Count == 1)
            {
                Vector3 location = list.SelectedItems[0].Tag as Vector3;

                var address = new Pointer(xivgame.Process, xivgame.Definitions.ActorTable + 8, 0);

                proc.Write(address + xivgame.Definitions.PositionX, location.x);
                proc.Write(address + xivgame.Definitions.PositionY, location.y);
                proc.Write(address + xivgame.Definitions.PositionZ, location.z);
            }
        }

        private void listView_NPC_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Teleport_ListView((ListView)sender);
        }

        private void listView_Mobs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Teleport_ListView((ListView)sender);
        }

        private void listView_Entities_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Teleport_ListView((ListView)sender);
        }
    }
}
