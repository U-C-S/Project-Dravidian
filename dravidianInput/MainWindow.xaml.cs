using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
            KeyboardRender();
        }

        public void KeyboardRender()
        {
            for (int i = 0; i < Unicode.vowel_sound.Length; i++) BtnRenderer(Unicode.vowel_sound[i], "Vani", Grid0, "s");
            for (int i = 0; i < Unicode.vowel_sound2.Length; i++) BtnRenderer(Unicode.vowel_sound2[i], "Vani", Grid8, "s");
            for (int i = 0; i < Unicode.vowels.Length; i++) BtnRenderer(Unicode.vowels[i], "NTR", Grid1, "v");
            for (int i = 0; i < Unicode.consonats2.Length; i++) BtnRenderer(Unicode.consonats2[i], "NTR", Grid7, "c");
            
            StackPanel[] grids = { Grid2, Grid3, Grid4, Grid5, Grid6 };
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    BtnRenderer(Unicode.consonats[i, j], "NTR", grids[i], "c");
                }
            }
        }

        private void BtnRenderer(string content, string fontFamily, StackPanel grid, string tag)
        {
            Button UnicodeBtn = new Button
            {
                Content = content,
                Cursor = Cursors.Hand,
                Width = 45,
                FontSize = 18,
                FontFamily = new FontFamily(fontFamily),
                Tag = tag
            };
            UnicodeBtn.Click += new RoutedEventHandler(CharacterClick);
            grid.Children.Add(UnicodeBtn);
        }

        string previousUnicode = "x";
        private void CharacterClick(object sender, RoutedEventArgs e)
        {
            Button pressedBtn = (sender as Button);
            string tag = (string)pressedBtn.Tag;
            if(tag == "s")
            {
                if(previousUnicode == "x" || previousUnicode == "s")
                {

                }
                else
                {
                    output.Text += pressedBtn.Content;
                    previousUnicode = tag;
                }
            }
            else if(tag == "v")
            {
                if(previousUnicode == "x")
                {
                    output.Text += pressedBtn.Content;
                    previousUnicode = tag;
                }
            }
            else if(tag == "c")
            {
                output.Text += pressedBtn.Content;
                previousUnicode = tag;
            }
        }

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

        private void Backspace_Click(object sender, RoutedEventArgs e)
        {
            if(output.Text.Length != 0)
            output.Text = output.Text.Substring(0, output.Text.Length - 1);
        }

        private void Space_Click(object sender, RoutedEventArgs e)
        {
            output.Text += (sender as Button).Content;
            previousUnicode = "x";
        }
    }
}
