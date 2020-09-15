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

namespace Telugu_Prototype_Typing_Keyboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Keyboard_press(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.A)
            {
                output.Text += "\u0C15";
            }
            else if(e.Key == Key.B)
            {
                output.Text += "\u0C3F";
            }
        }
    }
}
