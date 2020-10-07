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
            StackPanel[] grids = { Grid2, Grid3, Grid4, Grid5, Grid6 };

            for (int i = 0; i < Unicode.vowel_sound.Length; i++)
            {
                ButtonRenderer(Unicode.vowel_sound[i], "Vani", Grid0);
            }
            for (int i = 0; i < Unicode.vowel_sound2.Length; i++)
            {
                ButtonRenderer(Unicode.vowel_sound2[i], "Vani", Grid8);
            }
            for (int i = 0; i < Unicode.vowels.Length; i++)
            {
                ButtonRenderer(Unicode.vowels[i], "NTR", Grid1);
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    ButtonRenderer(Unicode.consonats[i,j], "NTR", grids[i]);
                }
            }
            for (int i = 0; i < Unicode.consonats2.Length; i++)
            {
                ButtonRenderer(Unicode.consonats2[i], "NTR", Grid7);
            }
        }

        private void ButtonRenderer(string content, string fontFamily, StackPanel grid)
        {
            Button UnicodeBtn = new Button
            {
                Content = content,
                Width = 45,
                FontSize = 18,
                FontFamily = new FontFamily(fontFamily)
            };
            UnicodeBtn.Click += new RoutedEventHandler(CharacterClick);
            grid.Children.Add(UnicodeBtn);
        }

        private void CharacterClick(object sender, RoutedEventArgs e) => output.Text += (sender as Button).Content;
        private void CopytoClip(object sender, RoutedEventArgs e) => Clipboard.SetText(output.Text);

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

    }
}
