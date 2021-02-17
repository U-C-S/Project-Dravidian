using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace std_mappings
{
    public class TeluguUnicode
    {
        private const string _sound = "\u0C4D";
        private const string
            ah = "\u0C05",
            aah = "\u0C06",
            e = "\u0C07",
            ee = "\u0C08",
            vu = "\u0C09",
            vuu = "\u0C0A",
            ru = "\u0C0B",
            ruu = "\u0C60",
            a = "\u0C0E",
            aa = "\u0C0F",
            i = "\u0C10",
            o = "\u0C12",
            oo = "\u0C13",
            ow = "\u0C14";

        private const string
            _aah = "\u0C3E",
            _e = "\u0C3F",
            _ee = "\u0C40",
            _vu = "\u0C41",
            _vuu = "\u0C42",
            _ru = "\u0C43",
            _ruu = "\u0C44",
            _a = "\u0C46",
            _aa = "\u0C47",
            _i = "\u0C48",
            _o = "\u0C4A",
            _oo = "\u0C4B",
            _ow = "\u0C4C",
            _nn = "\u0C01",
            _um = "\u0C02",
            _aha = "\u0C03";

        private const string
            ka = "\u0C15",
            kaa = "\u0C16",
            ga = "\u0C17",
            gaa = "\u0C18",
            ini = "\u0C19",

            cha = "\u0C1A",
            chaa = "\u0C1B",
            jha = "\u0C1C",
            jhaa = "\u0C1D",
            inya = "\u0C1E",

            ta = "\u0C1F",
            taa = "\u0C20",
            da = "\u0C21",
            daa = "\u0C22",
            ana = "\u0C23",

            tha = "\u0C24",
            thaa = "\u0C25",
            dha = "\u0C26",
            dhaa = "\u0C27",
            na = "\u0C28",

            pa = "\u0C2A",
            paa = "\u0C2B",
            ba = "\u0C2C",
            baa = "\u0C2D",
            ma = "\u0C2E",

            ya = "\u0C2F",
            ra = "\u0C30",
            bra = "\u0C31",
            la = "\u0C32",
            lla = "\u0C33",
            va = "\u0C35",
            say = "\u0C36",
            sha = "\u0C37",
            sa = "\u0C38",
            ha = "\u0C39";

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
