using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Zadanie_3._2._4 {
    class SmoothProgressBar : UserControl {
        public int Min { get; set; } = 0;
        public int Max { get; set; } = 100;
        private int _value = 0;
        public int Value {
            get {
                return _value;
            }
            set {
                if (value < Min) _value = Min;
                else if (value > Max) _value = Max;
                else _value = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e) {
            Graphics GDI = e.Graphics;
            SolidBrush brush = new SolidBrush(Color.Blue);
            double percent =(Value - Min)* 1.0 / (Max - Min);
            Rectangle rect = new Rectangle(Location.X, Location.Y,(int) (Width * percent), Height);

            GDI.FillRectangle(brush, rect);

            rect.Width = Width - 10;
            rect.Height -= 11;
            GDI.DrawRectangle(Pens.DarkBlue, rect);
        }
    }
}
