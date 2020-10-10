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
            for (int i = 0; i < TeluguUnicode.vowel_sound.Length; i++) BtnRenderer(TeluguUnicode.vowel_sound[i], "Vani", Grid0, "s");
            for (int i = 0; i < TeluguUnicode.vowel_sound2.Length; i++) BtnRenderer(TeluguUnicode.vowel_sound2[i], "Vani", Grid8, "s");
            for (int i = 0; i < TeluguUnicode.vowels.Length; i++) BtnRenderer(TeluguUnicode.vowels[i], "NTR", Grid1, "v");
            for (int i = 0; i < TeluguUnicode.consonats2.Length; i++) BtnRenderer(TeluguUnicode.consonats2[i], "NTR", Grid7, "c");
            
            StackPanel[] grids = { Grid2, Grid3, Grid4, Grid5, Grid6 };
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    BtnRenderer(TeluguUnicode.consonats[i, j], "NTR", grids[i], "c");
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

    public class TeluguUnicode
    {
        public string Lang = "telugu";

        public const string _sound = "\u0C4D";

        public const string ah = "\u0C05";
        public const string aah = "\u0C06";
        public const string e = "\u0C07";
        public const string ee = "\u0C08";
        public const string vu = "\u0C09";
        public const string vuu = "\u0C0A";
        public const string ru = "\u0C0B";
        public const string ruu = "\u0C60";
        public const string a = "\u0C0E";
        public const string aa = "\u0C0F";
        public const string i = "\u0C10";
        public const string o = "\u0C12";
        public const string oo = "\u0C13";
        public const string ow = "\u0C14";

        public const string _aah = "\u0C3E";
        public const string _e = "\u0C3F";
        public const string _ee = "\u0C40";
        public const string _vu = "\u0C41";
        public const string _vuu = "\u0C42";
        public const string _ru = "\u0C43";
        public const string _ruu = "\u0C44";
        public const string _a = "\u0C46";
        public const string _aa = "\u0C47";
        public const string _i = "\u0C48";
        public const string _o = "\u0C4A";
        public const string _oo = "\u0C4B";
        public const string _ow = "\u0C4C";

        public const string _nn = "\u0C01";
        public const string _um = "\u0C02";
        public const string _aha = "\u0C03";

        public const string ka = "\u0C15";
        public const string kaa = "\u0C16";
        public const string ga = "\u0C17";
        public const string gaa = "\u0C18";
        public const string ini = "\u0C19";

        public const string cha = "\u0C1A";
        public const string chaa = "\u0C1B";
        public const string jha = "\u0C1C";
        public const string jhaa = "\u0C1D";
        public const string inya = "\u0C1E";

        public const string ta = "\u0C1F";
        public const string taa = "\u0C20";
        public const string da = "\u0C21";
        public const string daa = "\u0C22";
        public const string ana = "\u0C23";

        public const string tha = "\u0C24";
        public const string thaa = "\u0C25";
        public const string dha = "\u0C26";
        public const string dhaa = "\u0C27";
        public const string na = "\u0C28";

        public const string pa = "\u0C2A";
        public const string paa = "\u0C2B";
        public const string ba = "\u0C2C";
        public const string baa = "\u0C2D";
        public const string ma = "\u0C2E";

        public const string ya = "\u0C2F";
        public const string ra = "\u0C30";
        public const string bra = "\u0C31";
        public const string la = "\u0C32";
        public const string lla = "\u0C33";
        public const string va = "\u0C35";
        public const string say = "\u0C36";
        public const string sha = "\u0C37";
        public const string sa = "\u0C38";
        public const string ha = "\u0C39";

        public static string[] vowel_sound = new string[14] { _sound, _aah, _e, _ee, _vu, _vuu, _ru, _ruu, _a, _aa, _i, _o, _oo, _ow };
        public static string[] vowel_sound2 = new string[3] { _nn, _um, _aha };
        public static string[] vowels = new string[14] { ah, aah, e, ee, vu, vuu, ru, ruu, a, aa, i, o, oo, ow };
        public static string[,] consonats = new string[5, 5] {
            { ka, kaa, ga, gaa, ini },
            { cha, chaa, jha, jhaa, inya },
            { ta, taa, da, daa, ana },
            { tha, thaa, dha, dhaa, na },
            { pa, paa, ba, baa, ma }
        };
        public static string[] consonats2 = new string[10] { ya, ra, la, va, say, sha, sa, ha, lla, bra };
    }
}
