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
using Input.Telugu;

namespace dravidianInput
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Renderr();
        }

        public void Renderr()
        {
            for (int i = 0; i <= 13; i++)
            {
                Button consbtn = new Button
                {
                    Content = Unicode.vowels[i],
                    Width = 40,
                    FontSize = 18,
                    FontFamily = new FontFamily("NTR")
                };
                consbtn.Click += new RoutedEventHandler(consClick);
                Grid0.Children.Add(consbtn);
            }
            StackPanel[] grids = { Grid1, Grid2, Grid3, Grid4, Grid5 };
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Button consbtn = new Button
                    {
                        Content = Unicode.consonats[i,j],
                        Width = 40,
                        FontSize = 18,
                        FontFamily = new FontFamily("NTR")
                    };
                    consbtn.Click += new RoutedEventHandler(consClick);
                    grids[i].Children.Add(consbtn);
                }
            }
            for (int i = 0; i < 11; i++)
            {
                Button consbtn = new Button
                {
                    Content = Unicode.consonats2[i],
                    Width = 40,
                    FontSize = 18,
                    FontFamily = new FontFamily("NTR")
                };
                consbtn.Click += new RoutedEventHandler(consClick);
                Grid6.Children.Add(consbtn);
            }
        }

        private void consClick(object sender, RoutedEventArgs e)
        {
            output.Text += (sender as Button).Content;
        }

        private void TextboxFontChange(object sender, SelectionChangedEventArgs e)
        {
            if (TextFontCombox.SelectedIndex == 0)
                output.FontFamily = new FontFamily("Segoe UI");
            if (TextFontCombox.SelectedIndex == 1)
                output.FontFamily = new FontFamily("Gautami");
            if (TextFontCombox.SelectedIndex == 2)
                output.FontFamily = new FontFamily("NTR");
            if (TextFontCombox.SelectedIndex == 3)
                output.FontFamily = new FontFamily("Vani");
        }

        /*
        private void Keyboard_press(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.A)
            {
                output.Text += Unicode.ka;
            }
            else if (e.Key == Key.B)
            {
                output.Text += "\u0C3F";
            }
            else if (e.Key == Key.S)
            {
                output.Text += "\u0C2A\u0C4D\u0C30";
            }
        }
        */

    }
}
