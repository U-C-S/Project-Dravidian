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

namespace Telugu_Prototype_Typing_Keyboard.UControls
{
    /// <summary>
    /// Interaction logic for UnicodeKeys.xaml
    /// </summary>
    public partial class UnicodeKeys : UserControl
    {
        public UnicodeKeys()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        public static readonly DependencyProperty unicodebtn = DependencyProperty.Register("Unicode",typeof(string),typeof(UnicodeKeys));
        public string Unicode
        {
            get { return (string)GetValue(unicodebtn); }
            set { SetValue(unicodebtn, value); }
        }
    }
}
