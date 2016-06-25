using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Zadanie_3._3._2 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void ProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {

        }

        private void button_Click(object sender, RoutedEventArgs e) {
            bar.Value += 10;
        }

        private void button1_Click(object sender, RoutedEventArgs e) {
            bar.Value -= 10;
        }

        private void button2_Click(object sender, RoutedEventArgs e) {
            bar.Value = bar.Minimum;
        }

        private void mediaElement_MediaEnded(object sender, RoutedEventArgs e) {
            mediaElement.Position = new TimeSpan(0, 0, 1);
            mediaElement.Play();
        }
    }
}
