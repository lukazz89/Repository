using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sztuczna_Inteligencja_Grafy_2
{
    class Program
    {    
        static void Main(string[] args)
        {
            //ushort[][] MacierzSasiedztwa = new ushort[11][];

            //MacierzSasiedztwa[0] = new ushort[11] { 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0 };
            //MacierzSasiedztwa[1] = new ushort[11] { 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 };
            //MacierzSasiedztwa[2] = new ushort[11] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1 };
            //MacierzSasiedztwa[3] = new ushort[11] { 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0 };
            //MacierzSasiedztwa[4] = new ushort[11] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 };
            //MacierzSasiedztwa[5] = new ushort[11] { 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0 };
            //MacierzSasiedztwa[6] = new ushort[11] { 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0 };
            //MacierzSasiedztwa[7] = new ushort[11] { 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0 };
            //MacierzSasiedztwa[8] = new ushort[11] { 1, 1, 0, 1, 0, 0, 0, 0, 0, 1, 1 };
            //MacierzSasiedztwa[9] = new ushort[11] { 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0 };
            //MacierzSasiedztwa[10] = new ushort[11] { 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0 };

            const ushort LiczbaWierzcholkow = 6;

            ushort[][] MacierzSasiedztwa = new ushort[6][];

            MacierzSasiedztwa[0] = new ushort[6] { 0, 1, 0, 0, 1, 0 };
            MacierzSasiedztwa[1] = new ushort[6] { 1, 0, 1, 0, 1, 1 };
            MacierzSasiedztwa[2] = new ushort[6] { 0, 1, 0, 1, 0, 0 };
            MacierzSasiedztwa[3] = new ushort[6] { 0, 0, 1, 0, 1, 1 };
            MacierzSasiedztwa[4] = new ushort[6] { 1, 1, 0, 1, 0, 1 };
            MacierzSasiedztwa[5] = new ushort[6] { 0, 1, 0, 1, 1, 0 };
           

            List<Color> TablicaKolorow  = new List<Color>()
            {
                Color.Blue,
                Color.Red,
                Color.Green,
                Color.Yellow,
                Color.White
            };

            var ListaWierzolkow = new Wierzcholek[LiczbaWierzcholkow];

            for (int i = 0; i < LiczbaWierzcholkow; i++)            
                ListaWierzolkow[i] = new Wierzcholek(LiczbaWierzcholkow);

            for (int i = 0; i < LiczbaWierzcholkow; i++)            
                ListaWierzolkow[i].UstawSasiadowIStopien(ListaWierzolkow, MacierzSasiedztwa[i]);            

            var PosortowaneWierzcholki = ListaWierzolkow.OrderByDescending(w => w.Stopien);           
            var tab = PosortowaneWierzcholki.ToArray<Wierzcholek>();

            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("Id: " + tab[i].Id + " Stopień: " + tab[i].Stopien);
                Console.WriteLine("Sąsiedzi:");
                foreach (var item in tab[i].Sasiedzi)
                {
                    Console.WriteLine(item.Id);
                }
            }

            tab[0].Kolor = TablicaKolorow[0];
            tab[0].IsKolorSet = true;
            for (int i = 1; i < tab.Length; i++)
            {
                foreach (var item in tab[i].Sasiedzi)
                {
                    if (item.IsKolorSet)
                    {
                        int x =  TablicaKolorow.IndexOf((Color)item.Kolor);
                        tab[i].TablicaDostepnosciKoloru[x] = false;
                    }
                }
                tab[i].Kolor = TablicaKolorow[tab[i].TablicaDostepnosciKoloru.ToList().IndexOf(true)];
                tab[i].IsKolorSet = true;
            }

            Console.WriteLine();
            Console.WriteLine("Wierzchłek newbieski: ");
            foreach (var item in tab)
            {
                if(item.Kolor == Color.Blue)
                    Console.WriteLine(item.Id);
            }

            Console.WriteLine();
            Console.WriteLine("Wierzchłek czerwony: ");
            foreach (var item in tab)
            {
                if (item.Kolor == Color.Red)
                    Console.WriteLine(item.Id);
            }

            Console.WriteLine();
            Console.WriteLine("Wierzchłek zelony: ");
            foreach (var item in tab)
            {
                if (item.Kolor == Color.Green)
                    Console.WriteLine(item.Id);
            }
            


          
            //ushort[] tab = new ushort[11];
            //for (int i = 0; i < 1; i++)
            //{
            //    for (int j = 0; j < MacierzSasiedztwa[i].Length; j++)
            //    {
            //        tab[j] = MacierzSasiedztwa[i][j];
            //    }
            //}
            //foreach (var item in tab)
            //{
            //    Console.WriteLine(item);
            //}       
            

          

            Console.ReadLine();
        }
    }
}
