using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_2._3._3 {
    public partial class Form1 : Form {
        public Form1() {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e) {
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e) {
            int szerokosc = e.ClipRectangle.Width;
            int wysokosc = e.ClipRectangle.Height;
            Graphics GDI = e.Graphics;
            GDI.Clear(Color.LightBlue);
            GDI.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Font myFont = new Font("Arial", 12, FontStyle.Bold);

            //Tarcza zegara
            GDI.DrawEllipse(new Pen(Color.White, 2), szerokosc / 2 - szerokosc / 3, wysokosc / 2 - wysokosc / 3, 2 * szerokosc / 3, 2 * wysokosc / 3);

            int i_h = DateTime.Now.Hour;
            int i_min = DateTime.Now.Minute;
            int i_sec = DateTime.Now.Second;

            Point Srodek = new Point(szerokosc / 2, wysokosc / 2);

            // Sekundy
            GDI.DrawLine(new Pen(Color.White, 2),
                         Srodek,
                         new Point(szerokosc / 2 + (int)(szerokosc / 3 * Math.Sin(2 * Math.PI * (double)i_sec / 60)),
                                   wysokosc / 2 - (int)(wysokosc / 3 * Math.Cos(2 * Math.PI * (double)i_sec / 60))));

            // Minuty
            GDI.DrawLine(new Pen(Color.LightCyan, 3),
                         Srodek,
                         new Point(szerokosc / 2 + (int)(0.8 * szerokosc / 3 * Math.Sin(2 * Math.PI * (double)i_min / 60)),
                                   wysokosc / 2 - (int)(0.8 * wysokosc / 3 * Math.Cos(2 * Math.PI * (double)i_min / 60))));

            // Godziny
            GDI.DrawLine(new Pen(Color.LightYellow, 4),
                         Srodek,
                         new Point(szerokosc / 2 + (int)(0.5 * szerokosc / 3 * Math.Sin(2 * Math.PI * (double)i_h / 12)),
                                   wysokosc / 2 - (int)(0.5 * wysokosc / 3 * Math.Cos(2 * Math.PI * (double)i_h / 12))));

            for (int i = 1; i <= 12; i++) {
                GDI.DrawLine(new Pen(Color.White, 2),
                             new Point(szerokosc / 2 + (int)(szerokosc / 3 * Math.Sin(2 * Math.PI * (double)i/ 12)),
                                       wysokosc / 2 - (int)(wysokosc / 3 * Math.Cos(2 * Math.PI * (double)i/ 12))),
                             new Point(szerokosc / 2 + (int)(0.8 * szerokosc / 3 * Math.Sin(2 * Math.PI * (double)i / 12)),
                                       wysokosc / 2 - (int)(0.8 * wysokosc / 3 * Math.Cos(2 * Math.PI * (double)i / 12))));
            }
        }
    }
}
