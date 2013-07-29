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
using System.Drawing;
using System.Drawing.Drawing2D;
using whiteRain.Objects;

namespace whiteRain
{
    class WoWMap
    {
        /// <summary>
        /// Returns a bitmap of the World of Warcraft minimap
        /// </summary>
        public static Bitmap Minimap(Size size, float Zoomfactor = 2.0f, WoWUnit SelectedUnit = null)
        {
            Bitmap Bmp = new Bitmap(size.Width, size.Height);

            using (Graphics Gr = Graphics.FromImage(Bmp))
            {
                Gr.SmoothingMode = SmoothingMode.HighQuality;
                Font DrawFont = new Font("Courier New", 12);

                float ObjectSize = 10.5f;

                //Level 1
                {
                    lock (WhiteRain.WoWUnitList) lock (WhiteRain.WoWCorpseList) lock (WhiteRain.WoWItemList)
                    {
                        foreach (WoWUnit WoWUnit in WhiteRain.WoWUnitList)
                        {
                            SolidBrush ColoredBrush;

                            var Object_X = ((WhiteRain.Me.Position.X - WoWUnit.Position.X) * Zoomfactor + (Bmp.Width / 2.0f));
                            var Object_Y = ((WhiteRain.Me.Position.Y - WoWUnit.Position.Y) * Zoomfactor + (Bmp.Height / 2.0f));

                            if (WoWUnit.IsNPC)
                            {
                                ColoredBrush = new SolidBrush(Color.Green);
                            }
                            else
                            {
                                ColoredBrush = new SolidBrush(Color.Red);
                            }

                            if (SelectedUnit != null)
                            {
                                if (WoWUnit.Guid == SelectedUnit.Guid)
                                {
                                    Gr.FillEllipse(new SolidBrush(Color.Purple), Object_X, Object_Y, ObjectSize, ObjectSize);
                                }
                                else
                                {
                                    Gr.FillEllipse(ColoredBrush, Object_X, Object_Y, ObjectSize, ObjectSize);
                                }
                            }
                            else
                            {
                                Gr.FillEllipse(ColoredBrush, Object_X, Object_Y, ObjectSize, ObjectSize);
                            }
                        }
                    }
                }
                //Level 2 
                {
                    Gr.FillEllipse(new SolidBrush(Color.Blue), (Bmp.Width / 2 + 1.50f), (Bmp.Height / 2 - 2.50f), ObjectSize, ObjectSize);
                    //Gr.DrawString(WhiteRain.Me.Name, DrawFont, new SolidBrush(Color.Black), new PointF((Bmp.Width / 2 - (WhiteRain.Me.Name.Length * 5.3f)), (Bmp.Height / 2 - 40)));
                }
                //Level 3
                {
                    Pen DottedPen = new Pen(Color.LightSlateGray);
                    DottedPen.DashPattern = new float[] { 4.0f, 4.0f };

                    //Gr.DrawPie(DottedPen, (Bmp.Width / 2 - 150), (Bmp.Height / 2 - 150), 300, 300, 360f, 360f);
                }
            }

            return (Bitmap) Bmp;
        }

        /// <summary>
        /// ..
        /// </summary>
        /// <param name="image"></param>
        /// <param name="newSize"></param>
        /// <returns></returns>
        public static Image ImageZoom(Image image, Size newSize)
        {
            var bitmap = new Bitmap(image, newSize.Width, newSize.Height);
            using (var g = Graphics.FromImage(bitmap))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            }

            return bitmap;
        }

    }
}
