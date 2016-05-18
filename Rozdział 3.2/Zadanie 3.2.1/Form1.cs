using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_3._2._1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            if(textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "") {
                MessageBox.Show($"Proszę uzupełnić dane.", "Uczelnia");
            }
            else MessageBox.Show($"{textBox1.Text}\n{textBox2.Text}\n{comboBox1.Text}\n{(checkBox1.Checked ? "Dzienne" : "")} {(checkBox2.Checked ? "Uzupełniające" : "")}", "Uczelnia");
        }
    }
}
