using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Namespace do Sruktury typu Clolr
using System.Drawing;

namespace Sztuczna_Inteligencja_Grafy_2
{
    public static class Dane
    {
        public static ushort[,] MacierzSasiedztwa = new ushort[11, 11]
        {
            {0,1,0,0,0,0,0,0,1,0,0},
            {0,1,0,0,0,0,0,0,1,0,0},
            {0,1,0,0,0,0,0,0,1,0,0},
            {0,1,0,0,0,0,0,0,1,0,0},
            {0,1,0,0,0,0,0,0,1,0,0},
            {0,1,0,0,0,0,0,0,1,0,0},
            {0,1,0,0,0,0,0,0,1,0,0},
            {0,1,0,0,0,0,0,0,1,0,0},
            {0,1,0,0,0,0,0,0,1,0,0},
            {0,1,0,0,0,0,0,0,1,0,0},
            {0,1,0,0,0,0,0,0,1,0,0}
        };

        public static Color[] TablicaKolorow = new Color[5]
        {
            Color.Blue,
            Color.Red,
            Color.Green,
            Color.Yellow,
            Color.White
        };

    }
}
