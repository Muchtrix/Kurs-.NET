using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_3._2._4 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            smoothProgressBar1.Value += 10;
        }

        private void button2_Click(object sender, EventArgs e) {
            smoothProgressBar1.Value -= 10;
        }
    }
}
