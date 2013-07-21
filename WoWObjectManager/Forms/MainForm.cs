using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WoWObjectManager.Objects;
using WoWObjectManager;

namespace WoWObjectManager.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ObjectManager.Initialize();
            if (ObjectManager.Initialized)
                LocalGUIDBox.Text = ObjectManager.Me.Guid.ToString();
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

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            //This is only the visual stuff for the form

            ObjectManager.Pulse();

            int index = 0;

            this.WoWUnitList.Items.Clear();
            this.WoWCorpseList.Items.Clear();
            this.WoWPLocalPlayerList.Items.Clear();
            this.WoWItemList.Items.Clear();

            foreach (WoWUnit WoWUnit in ObjectManager.WoWUnitList)
            {
                LogBox.AppendText(string.Format("=== [WoWUnit] Flag dump ===" + Environment.NewLine));
                LogBox.AppendText(string.Format("Name: {0}; HP: {1}/{2} {3}", WoWUnit.Name, WoWUnit.BaseHealth, WoWUnit.MaxHealth, Environment.NewLine));
                foreach (Offsets.UnitFlags flag in Enum.GetValues(typeof(Offsets.UnitFlags)))
                {
                    LogBox.AppendText(string.Format("{0}: {1} {2}", flag, WoWUnit.HasFlag(flag).ToString(), Environment.NewLine));
                }
                LogBox.AppendText(string.Format(Environment.NewLine));
            }


            //WoWUnitList
            index = 0;
            foreach (WoWUnit WoWUnit in ObjectManager.WoWUnitList)
            {
                this.WoWUnitList.Items.Add(index.ToString()).SubItems.AddRange(new string[] {
                    WoWUnit.Name, 
                    WoWUnit.DisplayId.ToString(), 
                    string.Format("{0}/{1}", WoWUnit.BaseHealth, WoWUnit.MaxHealth),
                    string.Format("{0}/{1}", WoWUnit.BasePower, WoWUnit.MaxPower),
                    string.Format("InCombat: {0}", WoWUnit.HasFlag(Offsets.UnitFlags.Combat).ToString()),
                    //string.Format("L: {0}", WoWUnit.HasDynamicFlag(Offsets.UnitDynamicFlags.Lootable).ToString()), //DynamicFlags
                    "TBA",
                    string.Format("R: {0} F: {1}", WoWUnit.HasNPCFlag(Offsets.WoWNpcFlags.CanRepair), WoWUnit.HasNPCFlag(Offsets.WoWNpcFlags.SellsFood)),
                    WoWUnit.Level.ToString(),
                    WoWUnit.CharmedBy.ToString(),
                    WoWUnit.SummonedBy.ToString(),
                    WoWUnit.CreatedBy.ToString(),
                    string.Format("X: {0} Y: {1} Z: {2}", WoWUnit.Position.X, WoWUnit.Position.Y, WoWUnit.Position.Z)
                 });

                index++;
            }

            //WoWLocalPlayerList
            {
                WoWPlayerMe Me = ObjectManager.Me;

                this.WoWPLocalPlayerList.Items.Add(Me.Name).SubItems.AddRange(new string[] {
                    string.Format("{0}/{1}", Me.BaseHealth, Me.MaxHealth),
                    string.Format("{0}/{1}", Me.BasePower, Me.MaxPower),
                    string.Format("{0}/{1}", Me.XP, Me.MaxXP),
                    string.Format("X: {0} Y: {1} Z: {2}", Me.Position.X, Me.Position.Y, Me.Position.Z),
                    Me.ContinentId.ToString(),
                    Me.ZoneText,
                    Me.SubZoneText,
                    Me.Class.ToString(),
                    Me.Level.ToString()
                });
            }

            //WoWCorpseList
            index = 0;
            foreach (WoWCorpse WoWCorpse in ObjectManager.WoWCorpseList)
            {
                this.WoWCorpseList.Items.Add(index.ToString()).SubItems.AddRange(new string[] {
                    WoWCorpse.Owner.ToString(),
                    WoWCorpse.MyCorpse.ToString(),
                    WoWCorpse.DisplayId.ToString(),
                    WoWCorpse.Flags.ToString(),
                    WoWCorpse.DynamicFlags.ToString(),
                    string.Format("X: {0} Y: {1} Z: {2}", WoWCorpse.Position.X, WoWCorpse.Position.Y, WoWCorpse.Position.Z)
                 });

                index++;
            }

            //WoWItemList
            index = 0;
            foreach (WoWItem WoWItem in ObjectManager.WoWItemList)
            {
                this.WoWItemList.Items.Add(index.ToString()).SubItems.AddRange(new string[] {
                    WoWItem.Owner.ToString(),
                    string.Format("{0}/{1} ({2}%)", WoWItem.Durability, WoWItem.MaxDurability, WoWItem.DurabilityPercent),
                    WoWItem.StackCount.ToString(),
                    WoWItem.Charges.ToString(),
                    WoWItem.ContainedIn.ToString(),
                    WoWItem.DynamicFlags.ToString(),
                    WoWItem.HasFlag(Offsets.WoWItemFlags.ItemFlagSoulbound).ToString(),
                   
                 });

                index++;
            }


            ResizeColumnHeaders();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            this.tabControl1.Width = this.Width;
            this.tabControl1.Height = this.Height;

            foreach (TabPage tabPage in tabControl1.TabPages)
            {
                foreach (Control cntrl in tabPage.Controls)
                {
                    cntrl.Width = (this.Width - 20);
                    cntrl.Height = (this.Height - 75);
                }
            }

            RefreshBtn.Location = new Point((this.Width - 100), 12);
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            ResizeColumnHeaders();
        }
    }
}
