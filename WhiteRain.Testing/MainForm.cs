/*
 * This file is part of the WoWObjectManager (C) 2013 Finn Grimpe
 * Copyright 2013 Finn Grimpe, All Rights Reserved
 * 
 * Github:  https://github.com/finndev/WoWObjectManager/
 * Website: http://finn.lu/
 * License: http://finn.lu/license
 *
 */

using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using whiteRain;
using whiteRain.Objects;

namespace whiteRain.Testing
{
    public partial class MainForm : Form
    {
        Rectangle rect;
        //bool IsDrawingRectangle;
        float Zoomfactor = 2.0f;
        Point MousePoint;
        WoWUnit SelectedUnit;

        Thread MapThread;

        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false; 
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                WhiteRain.Initialize(Process.GetProcessesByName("Wow").FirstOrDefault(), new WhiteRain.LaunchParameters { UpdateAutomatically = true});
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            #region Populate the Zoomfactor box
                        float[] Zoomfactors = new float[] { .4f, .6f, 1f, 1.4f, 1.8f, 2.0f, 2.4f, 3f, 3.5f, 4f, 5f, 6f, 8f, 10f, 13f, 15f  };
                        foreach (float zf in Zoomfactors)
                        {
                            zoomFactorComboBox.Items.Add(zf.ToString("#0.##%"));
                        }
                        zoomFactorComboBox.Text = "200%"; //Yup, this looks strange. However, SelectedIndex doesnt work and this does the same.
            #endregion

            if (!WhiteRain.Initialized)
                return;

            #region Mah Dirty Form Stuff

            RefreshListView();

            MapThread = new Thread(delegate()
            {
                for (;;)
                {
                    RedrawMap();
                }
            });
            MapThread.Start();

            #endregion
        }

        #region Mah Dirty Form Stuff² (only for testing n stuff!)

        private void WoWMapBmp_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0)
            {
                Zoomfactor -= 0.05f;
            }
            else
            {
                Zoomfactor += 0.05f;
            }
        }

        private void ResizeColumnHeaders()
        {
            foreach (TabPage tabPage in tabControl1.TabPages)
            {
                foreach (Control cntrl in tabPage.Controls)
                {
                    if (cntrl is ListView)
                    {
                        for (int i = 0; i < ((ListView)cntrl).Columns.Count - 1; i++)
                        {
                            ((ListView)cntrl).AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.HeaderSize);
                            ((ListView)cntrl).Columns[((ListView)cntrl).Columns.Count - 1].Width = -2;
                        }
                    }
                }
            }
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            ResizeColumnHeaders();
        }

        private void WoWUnitList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ulong SelectedGuid = Convert.ToUInt64(e.Item.SubItems[2].Text);
            WoWObjectType ObjectType = (WoWObjectType)Convert.ToInt32(e.Item.SubItems[1].Text);


            if (ObjectType == WoWObjectType.Unit)
            {
                WoWUnit WoWUnit = WhiteRain.WoWUnitList.Where(Obj => Obj.Guid == SelectedGuid).FirstOrDefault();
                objectProperties.SelectedObject = WoWUnit;
            }
            if (ObjectType == WoWObjectType.GameObject)
            {
                WoWGameObject WoWGameObject = WhiteRain.WoWGameObjectList.Where(Obj => Obj.Guid == SelectedGuid).FirstOrDefault();
                objectProperties.SelectedObject = WoWGameObject;
            }
        }

        private void RefreshListView()
        {
            if (!WhiteRain.Initialized)
                return;

            WhiteRain.Pulse();
            this.WoWUnitList.Items.Clear();

            //All WoWUnits
            foreach (WoWUnit WoWUnit in WhiteRain.WoWUnitList)
            {
                this.WoWUnitList.Items.Add("0x" + WoWUnit.BaseAddress.ToString("X")).SubItems.AddRange(new string[] {
                    WoWUnit.Type.ToString(),
                    WoWUnit.Guid.ToString(),
                    WoWUnit.Name,
                 });
            }
            //All WoWCorpses
            foreach (WoWCorpse WoWCorpse in WhiteRain.WoWCorpseList)
            {
                this.WoWUnitList.Items.Add("0x" + WoWCorpse.BaseAddress.ToString("X")).SubItems.AddRange(new string[] {
                    WoWCorpse.Type.ToString(),
                    WoWCorpse.Guid.ToString(),
                    "Corpse"
                 });
            }
            //All WoWGameObjects
            foreach (WoWGameObject WoWGameObject in WhiteRain.WoWGameObjectList.Where(obj => obj.CreatedBy == WhiteRain.Me.Guid))
            {
                this.WoWUnitList.Items.Add("0x" + WoWGameObject.BaseAddress.ToString("X")).SubItems.AddRange(new string[] {
                    WoWGameObject.Type.ToString(),
                    WoWGameObject.Guid.ToString(),
                    "GameObject"
                 });
            }
            //All WoWItems
            foreach (WoWItem WoWItem in WhiteRain.WoWItemList)
            {
                this.WoWUnitList.Items.Add("0x" + WoWItem.BaseAddress.ToString("X")).SubItems.AddRange(new string[] {
                    WoWItem.Type.ToString(),
                    WoWItem.Guid.ToString(),
                    "Item"
                 });
            }

            ResizeColumnHeaders();
        }

        private void refreshToolStripBtn_Click_1(object sender, EventArgs e)
        {
            RefreshListView();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(1337);
        }

        private void WoWMapBmp_MouseDown(object sender, MouseEventArgs e)
        {
            //IsDrawingRectangle = true;
            //rect = new Rectangle(e.X, e.Y, 0, 0);
            //WoWMapBmp.Refresh();
        }

        private void WoWMapBmp_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                rect = new Rectangle(rect.Left, rect.Top, e.X - rect.Left, e.Y - rect.Top);
            }

            MouseCoords.Text = string.Format("X: {0} Y: {1}", e.X, e.Y);
            MousePoint = new Point(e.X, e.Y);
        }

        private void WoWMapBmp_Paint(object sender, PaintEventArgs e)
        {
            /*return; 

            if (!IsDrawingRectangle)
                return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            //Draw border of the rectangle
            Pen pen = new Pen(Color.Black, 1);
            pen.DashCap = System.Drawing.Drawing2D.DashCap.Round;
            pen.DashPattern = new float[] { 1f, 1f };
            pen.Alignment = PenAlignment.Inset;
            e.Graphics.DrawRectangle(pen, rect);
            //Draw a filled rectangle
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(150, 210, 232, 255)), rect);
            WoWMapBmp.Refresh();*/
        }

        private void WoWMapBmp_MouseUp(object sender, MouseEventArgs e)
        {
            //IsDrawingRectangle = false;
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Zoomfactor = (float) double.Parse(zoomFactorComboBox.SelectedItem.ToString().Replace("%", "")) / 100;
            RedrawMap();
        }

        private void RedrawMap()
        {
            try
            {
                this.WoWMapBmp.BackgroundImage = WoWMap.Minimap(new Size(WoWMapBmp.Size.Width, WoWMapBmp.Size.Height), Zoomfactor, SelectedUnit); //Redraw map
                zoomFactorComboBox.Text = string.Format("{0}", Zoomfactor.ToString("#0.##%"));
            }
            catch (Exception) { }
        }

        private void zoomFactorIncrease_Click(object sender, EventArgs e)
        {
            Zoomfactor += .2f;
            RedrawMap();
        }

        private void zoomFactorDecrease_Click(object sender, EventArgs e)
        {
            if ((Zoomfactor - .2f) < 0.4f)
                return;

            Zoomfactor -= .2f;
            RedrawMap();
        }

        private void WoWMapBmp_Click(object sender, EventArgs e)
        {
            //Find nearest object
            double ClosestUnitDistance = 1000;
            WoWUnit ClosestUnit = new WoWUnit((IntPtr) 0x10000);
            Point ClosestUnitPoints = new Point(0, 0);
            foreach (WoWUnit WoWUnit in WhiteRain.WoWUnitList)
            {
                var Object_X = ((WhiteRain.Me.Position.X - WoWUnit.Position.X) * Zoomfactor + (WoWMapBmp.Width / 2.0f));
                var Object_Y = ((WhiteRain.Me.Position.Y - WoWUnit.Position.Y) * Zoomfactor + (WoWMapBmp.Height / 2.0f));

                var xd = (Object_X - MousePoint.X);
                var yd = (Object_Y - MousePoint.Y);
                double Distance = Math.Sqrt(xd * xd + yd * yd); //2D distance

                if (Distance < ClosestUnitDistance)
                {
                    ClosestUnitDistance = Distance;
                    ClosestUnit = WoWUnit;
                }
            }

            if (ClosestUnitDistance == 1000)
                return;

            objectProperties.SelectedObject = ClosestUnit; //Update PropertyGrid
            SelectedUnit = ClosestUnit;
            RedrawMap(); //Redrawp map so the selected Unit is in a different colour on the map
            objectProperties.Refresh(); //Refresh it
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void WoWMapBmp_MouseEnter(object sender, EventArgs e)
        {
            WoWMapBmp.Focus();
            WoWMapBmp.MouseWheel += new MouseEventHandler(WoWMapBmp_MouseWheel);
        }

        #endregion
    }
}
