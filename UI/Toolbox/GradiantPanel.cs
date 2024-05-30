﻿using System.Drawing.Drawing2D;

namespace UI.Toolbox
{
    public class GradiantPanel : Panel
    {
        public Color TopColor { get; set; }
        public Color BottomColor { get; set;}
        public float Angle { get; set; }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality; // Fjernet vertikal pixel linje
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.TopColor, this.BottomColor, this.Angle);
            Graphics g = e.Graphics;
            g.FillRectangle(brush, this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}
