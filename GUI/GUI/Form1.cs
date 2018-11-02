using GUI.Actor.Model;
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
        }
    }
}
