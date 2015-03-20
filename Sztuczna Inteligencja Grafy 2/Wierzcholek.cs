using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Namespace do Sruktury typu Clolr
using System.Drawing;

namespace Sztuczna_Inteligencja_Grafy_2
{
    public class Wierzcholek
    {
        public static ushort Counter = 0;

        public ushort Id { get; set; }
        public bool IsKolorSet { get; set; }
        public Color? Kolor { get; set; }     
        public bool[] TablicaDostepnosciKoloru;           
        public List<Wierzcholek> Sasiedzi { get; set; }
        public ushort Stopien { get; set; }        

        public Wierzcholek() { }

        public Wierzcholek(ushort liczbaWiechcholkow)
        {
            Id = Counter;
            IsKolorSet = false;
            Kolor = null;            
            Sasiedzi = new List<Wierzcholek>();
            Stopien = 0;
            TablicaDostepnosciKoloru = new bool[liczbaWiechcholkow];
            for (int i = 0; i < TablicaDostepnosciKoloru.Length; i++)
                TablicaDostepnosciKoloru[i] = true;
            Counter++;
        }

        public void UstawSasiadowIStopien(Wierzcholek[] Listawiewcholkow, ushort[] tabSasiadow)
        {
            int licznik = 0;
            foreach (var num in tabSasiadow)
            {
                if (num == 1)
                    this.Sasiedzi.Add(Listawiewcholkow.FirstOrDefault(w => w.Id == licznik));
                licznik++;
            }
            this.Stopien = (ushort)this.Sasiedzi.Count();
        }

    }
}
