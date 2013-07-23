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
            this.columnHeader35 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader34 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.WoWMapBmp = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.zoomFactorIncrease = new System.Windows.Forms.ToolStripButton();
            this.zoomFactorDecrease = new System.Windows.Forms.ToolStripButton();
            this.zoomFactorComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.MouseCoords = new System.Windows.Forms.ToolStripLabel();
            this.objCoords = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.SelectionCoords = new System.Windows.Forms.ToolStripLabel();
            this.objectProperties = new System.Windows.Forms.PropertyGrid();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WoWMapBmp)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(238, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(683, 496);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.WoWUnitList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(675, 470);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "WoWObject";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // WoWUnitList
            // 
            this.WoWUnitList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader35,
            this.columnHeader16,
            this.columnHeader34});
            this.WoWUnitList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WoWUnitList.FullRowSelect = true;
            this.WoWUnitList.GridLines = true;
            this.WoWUnitList.Location = new System.Drawing.Point(3, 3);
            this.WoWUnitList.MultiSelect = false;
            this.WoWUnitList.Name = "WoWUnitList";
            this.WoWUnitList.Size = new System.Drawing.Size(669, 464);
            this.WoWUnitList.TabIndex = 2;
            this.WoWUnitList.UseCompatibleStateImageBehavior = false;
            this.WoWUnitList.View = System.Windows.Forms.View.Details;
            this.WoWUnitList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.WoWUnitList_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "BaseAddress";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader35
            // 
            this.columnHeader35.Text = "Type";
            this.columnHeader35.Width = 100;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Guid";
            this.columnHeader16.Width = 180;
            // 
            // columnHeader34
            // 
            this.columnHeader34.Text = "Name";
            this.columnHeader34.Width = 180;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.WoWMapBmp);
            this.tabPage6.Controls.Add(this.toolStrip1);
            this.tabPage6.Controls.Add(this.toolStrip2);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(675, 470);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Minimap";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // WoWMapBmp
            // 
            this.WoWMapBmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WoWMapBmp.Location = new System.Drawing.Point(0, 25);
            this.WoWMapBmp.Name = "WoWMapBmp";
            this.WoWMapBmp.Size = new System.Drawing.Size(675, 420);
            this.WoWMapBmp.TabIndex = 4;
            this.WoWMapBmp.TabStop = false;
            this.WoWMapBmp.Click += new System.EventHandler(this.WoWMapBmp_Click);
            this.WoWMapBmp.Paint += new System.Windows.Forms.PaintEventHandler(this.WoWMapBmp_Paint);
            this.WoWMapBmp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WoWMapBmp_MouseDown);
            this.WoWMapBmp.MouseEnter += new System.EventHandler(this.WoWMapBmp_MouseEnter);
            this.WoWMapBmp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WoWMapBmp_MouseMove);
            this.WoWMapBmp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WoWMapBmp_MouseUp);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomFactorIncrease,
            this.zoomFactorDecrease,
            this.zoomFactorComboBox});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(675, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // zoomFactorIncrease
            // 
            this.zoomFactorIncrease.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomFactorIncrease.Image = global::WoWObjectManager.Properties.Resources.magnifier_zoom_in;
            this.zoomFactorIncrease.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomFactorIncrease.Name = "zoomFactorIncrease";
            this.zoomFactorIncrease.Size = new System.Drawing.Size(23, 22);
            this.zoomFactorIncrease.Text = "toolStripButton1";
            this.zoomFactorIncrease.Click += new System.EventHandler(this.zoomFactorIncrease_Click);
            // 
            // zoomFactorDecrease
            // 
            this.zoomFactorDecrease.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomFactorDecrease.Image = global::WoWObjectManager.Properties.Resources.magnifier_zoom_out;
            this.zoomFactorDecrease.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomFactorDecrease.Name = "zoomFactorDecrease";
            this.zoomFactorDecrease.Size = new System.Drawing.Size(23, 22);
            this.zoomFactorDecrease.Text = "toolStripButton2";
            this.zoomFactorDecrease.Click += new System.EventHandler(this.zoomFactorDecrease_Click);
            // 
            // zoomFactorComboBox
            // 
            this.zoomFactorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.zoomFactorComboBox.Name = "zoomFactorComboBox";
            this.zoomFactorComboBox.Size = new System.Drawing.Size(121, 25);
            this.zoomFactorComboBox.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.MouseCoords,
            this.objCoords,
            this.toolStripLabel2,
            this.toolStripButton4,
            this.SelectionCoords});
            this.toolStrip2.Location = new System.Drawing.Point(0, 445);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(675, 25);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::WoWObjectManager.Properties.Resources.cursor;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // MouseCoords
            // 
            this.MouseCoords.Name = "MouseCoords";
            this.MouseCoords.Size = new System.Drawing.Size(64, 22);
            this.MouseCoords.Text = "X: {0} Y: {1}";
            // 
            // objCoords
            // 
            this.objCoords.Name = "objCoords";
            this.objCoords.Size = new System.Drawing.Size(64, 22);
            this.objCoords.Text = "X: {0} Y: {1}";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(346, 22);
            this.toolStripLabel2.Text = "                                                                                 " +
    "                                ";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::WoWObjectManager.Properties.Resources.selection_select;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.toolStripButton4.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical270;
            // 
            // SelectionCoords
            // 
            this.SelectionCoords.Name = "SelectionCoords";
            this.SelectionCoords.Size = new System.Drawing.Size(130, 22);
            this.SelectionCoords.Text = "X: {0} Y: {1} W: {2} H: {3}";
            // 
            // objectProperties
            // 
            this.objectProperties.CommandsBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.objectProperties.CommandsDisabledLinkColor = System.Drawing.Color.Black;
            this.objectProperties.Dock = System.Windows.Forms.DockStyle.Left;
            this.objectProperties.LineColor = System.Drawing.Color.LightGray;
            this.objectProperties.Location = new System.Drawing.Point(0, 23);
            this.objectProperties.Name = "objectProperties";
            this.objectProperties.Size = new System.Drawing.Size(238, 496);
            this.objectProperties.TabIndex = 15;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.refreshToolStripBtn});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(921, 23);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(51, 19);
            this.toolStripMenuItem1.Text = "Menu";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // refreshToolStripBtn
            // 
            this.refreshToolStripBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshToolStripBtn.Name = "refreshToolStripBtn";
            this.refreshToolStripBtn.Size = new System.Drawing.Size(63, 19);
            this.refreshToolStripBtn.Text = "Refresh";
            this.refreshToolStripBtn.Click += new System.EventHandler(this.refreshToolStripBtn_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 519);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.objectProperties);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WoWMapBmp)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView WoWUnitList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.ColumnHeader columnHeader35;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader34;
        private System.Windows.Forms.PropertyGrid objectProperties;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripBtn;
        private System.Windows.Forms.PictureBox WoWMapBmp;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton zoomFactorIncrease;
        private System.Windows.Forms.ToolStripButton zoomFactorDecrease;
        private System.Windows.Forms.ToolStripComboBox zoomFactorComboBox;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripLabel MouseCoords;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripLabel SelectionCoords;
        private System.Windows.Forms.ToolStripLabel objCoords;
    }
}