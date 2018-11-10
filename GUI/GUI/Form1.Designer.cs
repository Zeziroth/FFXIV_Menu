namespace GUI
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView_Player = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tPHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView_NPC = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_Mobs = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_Entities = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkBox_Playerlist = new System.Windows.Forms.CheckBox();
            this.checkBox_NPCList = new System.Windows.Forms.CheckBox();
            this.checkBox_MobList = new System.Windows.Forms.CheckBox();
            this.checkBox_EntityList = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // listView_Player
            // 
            this.listView_Player.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader9});
            this.listView_Player.ContextMenuStrip = this.contextMenuStrip1;
            this.listView_Player.FullRowSelect = true;
            this.listView_Player.Location = new System.Drawing.Point(6, 3);
            this.listView_Player.MultiSelect = false;
            this.listView_Player.Name = "listView_Player";
            this.listView_Player.Size = new System.Drawing.Size(463, 304);
            this.listView_Player.TabIndex = 1;
            this.listView_Player.UseCompatibleStateImageBehavior = false;
            this.listView_Player.View = System.Windows.Forms.View.Details;
            this.listView_Player.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_Player_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Username";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Level";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Distance";
            this.columnHeader9.Width = 100;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tPHereToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(115, 26);
            // 
            // tPHereToolStripMenuItem
            // 
            this.tPHereToolStripMenuItem.Name = "tPHereToolStripMenuItem";
            this.tPHereToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.tPHereToolStripMenuItem.Text = "TP here";
            this.tPHereToolStripMenuItem.Click += new System.EventHandler(this.tPHereToolStripMenuItem_Click);
            // 
            // listView_NPC
            // 
            this.listView_NPC.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader10});
            this.listView_NPC.ContextMenuStrip = this.contextMenuStrip1;
            this.listView_NPC.FullRowSelect = true;
            this.listView_NPC.Location = new System.Drawing.Point(6, 3);
            this.listView_NPC.MultiSelect = false;
            this.listView_NPC.Name = "listView_NPC";
            this.listView_NPC.Size = new System.Drawing.Size(463, 304);
            this.listView_NPC.TabIndex = 2;
            this.listView_NPC.UseCompatibleStateImageBehavior = false;
            this.listView_NPC.View = System.Windows.Forms.View.Details;
            this.listView_NPC.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_NPC_MouseDoubleClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Username";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Level";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Distance";
            this.columnHeader10.Width = 100;
            // 
            // listView_Mobs
            // 
            this.listView_Mobs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader11});
            this.listView_Mobs.ContextMenuStrip = this.contextMenuStrip1;
            this.listView_Mobs.FullRowSelect = true;
            this.listView_Mobs.Location = new System.Drawing.Point(6, 3);
            this.listView_Mobs.MultiSelect = false;
            this.listView_Mobs.Name = "listView_Mobs";
            this.listView_Mobs.Size = new System.Drawing.Size(463, 304);
            this.listView_Mobs.TabIndex = 3;
            this.listView_Mobs.UseCompatibleStateImageBehavior = false;
            this.listView_Mobs.View = System.Windows.Forms.View.Details;
            this.listView_Mobs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_Mobs_MouseDoubleClick);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Username";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Level";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Distance";
            this.columnHeader11.Width = 100;
            // 
            // listView_Entities
            // 
            this.listView_Entities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader12});
            this.listView_Entities.ContextMenuStrip = this.contextMenuStrip1;
            this.listView_Entities.FullRowSelect = true;
            this.listView_Entities.Location = new System.Drawing.Point(6, 3);
            this.listView_Entities.MultiSelect = false;
            this.listView_Entities.Name = "listView_Entities";
            this.listView_Entities.Size = new System.Drawing.Size(463, 304);
            this.listView_Entities.TabIndex = 4;
            this.listView_Entities.UseCompatibleStateImageBehavior = false;
            this.listView_Entities.View = System.Windows.Forms.View.Details;
            this.listView_Entities.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_Entities_MouseDoubleClick);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Username";
            this.columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Level";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Distance";
            this.columnHeader12.Width = 100;
            // 
            // checkBox_Playerlist
            // 
            this.checkBox_Playerlist.AutoSize = true;
            this.checkBox_Playerlist.Checked = true;
            this.checkBox_Playerlist.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Playerlist.Location = new System.Drawing.Point(6, 308);
            this.checkBox_Playerlist.Name = "checkBox_Playerlist";
            this.checkBox_Playerlist.Size = new System.Drawing.Size(51, 18);
            this.checkBox_Playerlist.TabIndex = 6;
            this.checkBox_Playerlist.Text = "Scan";
            this.checkBox_Playerlist.UseVisualStyleBackColor = true;
            // 
            // checkBox_NPCList
            // 
            this.checkBox_NPCList.AutoSize = true;
            this.checkBox_NPCList.Checked = true;
            this.checkBox_NPCList.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_NPCList.Location = new System.Drawing.Point(6, 308);
            this.checkBox_NPCList.Name = "checkBox_NPCList";
            this.checkBox_NPCList.Size = new System.Drawing.Size(51, 18);
            this.checkBox_NPCList.TabIndex = 7;
            this.checkBox_NPCList.Text = "Scan";
            this.checkBox_NPCList.UseVisualStyleBackColor = true;
            // 
            // checkBox_MobList
            // 
            this.checkBox_MobList.AutoSize = true;
            this.checkBox_MobList.Checked = true;
            this.checkBox_MobList.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_MobList.Location = new System.Drawing.Point(6, 308);
            this.checkBox_MobList.Name = "checkBox_MobList";
            this.checkBox_MobList.Size = new System.Drawing.Size(51, 18);
            this.checkBox_MobList.TabIndex = 8;
            this.checkBox_MobList.Text = "Scan";
            this.checkBox_MobList.UseVisualStyleBackColor = true;
            // 
            // checkBox_EntityList
            // 
            this.checkBox_EntityList.AutoSize = true;
            this.checkBox_EntityList.Checked = true;
            this.checkBox_EntityList.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_EntityList.Location = new System.Drawing.Point(6, 308);
            this.checkBox_EntityList.Name = "checkBox_EntityList";
            this.checkBox_EntityList.Size = new System.Drawing.Size(51, 18);
            this.checkBox_EntityList.TabIndex = 9;
            this.checkBox_EntityList.Text = "Scan";
            this.checkBox_EntityList.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(485, 360);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView_Player);
            this.tabPage1.Controls.Add(this.checkBox_Playerlist);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(477, 333);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Player";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listView_NPC);
            this.tabPage2.Controls.Add(this.checkBox_NPCList);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(477, 333);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "NPC";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listView_Mobs);
            this.tabPage3.Controls.Add(this.checkBox_MobList);
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(477, 333);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mobs";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listView_Entities);
            this.tabPage4.Controls.Add(this.checkBox_EntityList);
            this.tabPage4.Location = new System.Drawing.Point(4, 23);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(477, 333);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Other";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Location = new System.Drawing.Point(562, 70);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            419,
            0,
            0,
            65536});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 1;
            this.numericUpDown2.Location = new System.Drawing.Point(562, 96);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            419,
            0,
            0,
            65536});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 12;
            this.numericUpDown2.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(542, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 14);
            this.label1.TabIndex = 13;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(542, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 14);
            this.label2.TabIndex = 14;
            this.label2.Text = "Y";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(562, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Port";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(724, 380);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "FFXIV";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tPHereToolStripMenuItem;
        private System.Windows.Forms.ListView listView_Player;
        private System.Windows.Forms.ListView listView_NPC;
        private System.Windows.Forms.ListView listView_Mobs;
        private System.Windows.Forms.ListView listView_Entities;
        private System.Windows.Forms.CheckBox checkBox_Playerlist;
        private System.Windows.Forms.CheckBox checkBox_NPCList;
        private System.Windows.Forms.CheckBox checkBox_MobList;
        private System.Windows.Forms.CheckBox checkBox_EntityList;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

