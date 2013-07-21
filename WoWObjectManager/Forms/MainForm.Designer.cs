namespace WoWObjectManager.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.WoWUnitList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.WoWCorpseList = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LocalGUIDBox = new System.Windows.Forms.TextBox();
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.WoWPLocalPlayerList = new System.Windows.Forms.ListView();
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader37 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader38 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader39 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader41 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader42 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader43 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader44 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.WoWItemList = new System.Windows.Forms.ListView();
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader32 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader28 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader30 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader31 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader29 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader33 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(983, 491);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.WoWUnitList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(975, 465);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "WoWUnit";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // WoWUnitList
            // 
            this.WoWUnitList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20});
            this.WoWUnitList.Location = new System.Drawing.Point(0, 0);
            this.WoWUnitList.Name = "WoWUnitList";
            this.WoWUnitList.Size = new System.Drawing.Size(972, 469);
            this.WoWUnitList.TabIndex = 0;
            this.WoWUnitList.UseCompatibleStateImageBehavior = false;
            this.WoWUnitList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "DisplayId";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Health";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Power/Mana";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Flags";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Lootable";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "NPCFlags*";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "DynamicFlags";
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "UnitRelation";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.WoWCorpseList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(975, 465);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "WoWCorpse";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // WoWCorpseList
            // 
            this.WoWCorpseList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader10,
            this.columnHeader9,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader24});
            this.WoWCorpseList.Location = new System.Drawing.Point(0, 0);
            this.WoWCorpseList.Name = "WoWCorpseList";
            this.WoWCorpseList.Size = new System.Drawing.Size(975, 465);
            this.WoWCorpseList.TabIndex = 1;
            this.WoWCorpseList.UseCompatibleStateImageBehavior = false;
            this.WoWCorpseList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Id";
            this.columnHeader7.Width = 40;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "OwnerGUID";
            this.columnHeader8.Width = 180;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Owner";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "DisplayId";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Flags";
            this.columnHeader11.Width = 70;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "DynamicFlags";
            this.columnHeader12.Width = 100;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.Location = new System.Drawing.Point(893, 11);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(75, 23);
            this.RefreshBtn.TabIndex = 1;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "LocalGUID:";
            // 
            // LocalGUIDBox
            // 
            this.LocalGUIDBox.Location = new System.Drawing.Point(70, 6);
            this.LocalGUIDBox.Name = "LocalGUIDBox";
            this.LocalGUIDBox.Size = new System.Drawing.Size(173, 20);
            this.LocalGUIDBox.TabIndex = 3;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "*: R = Repair; F: Sells Food/Drinking";
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "CharmedBy";
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "SummonedBy";
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "CreatedBy";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.WoWPLocalPlayerList);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(975, 465);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "LocalPlayer";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // WoWPLocalPlayerList
            // 
            this.WoWPLocalPlayerList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader22,
            this.columnHeader37,
            this.columnHeader38,
            this.columnHeader39,
            this.columnHeader41,
            this.columnHeader42,
            this.columnHeader43,
            this.columnHeader44,
            this.columnHeader23,
            this.columnHeader21});
            this.WoWPLocalPlayerList.Location = new System.Drawing.Point(1, -2);
            this.WoWPLocalPlayerList.Name = "WoWPLocalPlayerList";
            this.WoWPLocalPlayerList.Size = new System.Drawing.Size(972, 469);
            this.WoWPLocalPlayerList.TabIndex = 1;
            this.WoWPLocalPlayerList.UseCompatibleStateImageBehavior = false;
            this.WoWPLocalPlayerList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Name";
            this.columnHeader22.Width = 40;
            // 
            // columnHeader37
            // 
            this.columnHeader37.Text = "Health";
            // 
            // columnHeader38
            // 
            this.columnHeader38.Text = "Power";
            // 
            // columnHeader39
            // 
            this.columnHeader39.Text = "XP";
            // 
            // columnHeader41
            // 
            this.columnHeader41.Text = "Position";
            // 
            // columnHeader42
            // 
            this.columnHeader42.Text = "ContinentId";
            // 
            // columnHeader43
            // 
            this.columnHeader43.Text = "ZoneText";
            // 
            // columnHeader44
            // 
            this.columnHeader44.Text = "SubZoneText";
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Class";
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "Position (only for our own coprse)";
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Level";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.WoWItemList);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(975, 465);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "WoWItem";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // WoWItemList
            // 
            this.WoWItemList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader25,
            this.columnHeader32,
            this.columnHeader28,
            this.columnHeader30,
            this.columnHeader31,
            this.columnHeader26,
            this.columnHeader27,
            this.columnHeader29,
            this.columnHeader33});
            this.WoWItemList.Location = new System.Drawing.Point(0, 0);
            this.WoWItemList.Name = "WoWItemList";
            this.WoWItemList.Size = new System.Drawing.Size(975, 465);
            this.WoWItemList.TabIndex = 2;
            this.WoWItemList.UseCompatibleStateImageBehavior = false;
            this.WoWItemList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "Id";
            this.columnHeader25.Width = 40;
            // 
            // columnHeader32
            // 
            this.columnHeader32.Text = "OwnerGUID";
            // 
            // columnHeader28
            // 
            this.columnHeader28.Text = "Durability";
            // 
            // columnHeader30
            // 
            this.columnHeader30.Text = "StackCount";
            // 
            // columnHeader31
            // 
            this.columnHeader31.Text = "Charges";
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "ContainedIn";
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "DynamicFlags";
            // 
            // columnHeader29
            // 
            this.columnHeader29.Text = "Soulbound (exmaple)";
            // 
            // columnHeader33
            // 
            this.columnHeader33.Text = "ItemInfo";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 521);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LocalGUIDBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView WoWUnitList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.ListView WoWCorpseList;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LocalGUIDBox;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView WoWPLocalPlayerList;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader37;
        private System.Windows.Forms.ColumnHeader columnHeader38;
        private System.Windows.Forms.ColumnHeader columnHeader39;
        private System.Windows.Forms.ColumnHeader columnHeader41;
        private System.Windows.Forms.ColumnHeader columnHeader42;
        private System.Windows.Forms.ColumnHeader columnHeader43;
        private System.Windows.Forms.ColumnHeader columnHeader44;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView WoWItemList;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ColumnHeader columnHeader32;
        private System.Windows.Forms.ColumnHeader columnHeader28;
        private System.Windows.Forms.ColumnHeader columnHeader30;
        private System.Windows.Forms.ColumnHeader columnHeader31;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private System.Windows.Forms.ColumnHeader columnHeader27;
        private System.Windows.Forms.ColumnHeader columnHeader29;
        private System.Windows.Forms.ColumnHeader columnHeader33;
    }
}