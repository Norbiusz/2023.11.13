using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2023_11_13
{
    internal class Program
    {
        struct Telkek 
        {
            public int Adoszam;
            public string Utca;
            public string Haz_szam;
            public char Sav;
            public int Alap_ter;
        }

        static public int A_sav = 0;
        static public int B_sav = 0;
        static public int C_sav = 0;

        static int ado(char Ado_sav, int Ter)
        {
            int Negyzetm = 0;
            if (Ado_sav== 'A')
            {
                Negyzetm = A_sav;
            }
            if (Ado_sav == 'B')
            {
                Negyzetm = B_sav;
            }
            if (Ado_sav == 'C')
            {
                Negyzetm = C_sav;
            }
            int Fiz_ado = Negyzetm*Ter;
            
            return Fiz_ado;
        }
        static void Main(string[] args)
        {
            List<Telkek> adatok = new List<Telkek>();
            string[] darabol;
            Telkek adat = new Telkek();
            StreamReader sr = new StreamReader("utca.txt",Encoding.Default);
            darabol=sr.ReadLine().Split();
            A_sav = Convert.ToInt32(darabol[0]);
            B_sav = Convert.ToInt32(darabol[0]);
            C_sav = Convert.ToInt32(darabol[0]);
            while (!sr.EndOfStream)
            {
                darabol = sr.ReadLine().Split();
                adat.Adoszam = Convert.ToInt32(darabol[0]);
                adat.Utca = darabol[1];
                adat.Haz_szam = darabol[2];
                adat.Sav = Convert.ToChar(darabol[3]);
                adat.Alap_ter= Convert.ToInt32(darabol[4]);
                adatok.Add(adat);
            }
            sr.Close();
            Console.WriteLine($"2. feladat: Amintában {adatok.Count} telek szerepel.");
            Console.Write("3. feladat: Egy tulajdonos adószáma:");
            int megadott=Convert.ToInt32(Console.ReadLine());
            int db = 0;
            for (int i = 0; i <adatok.Count; i++)
            {
                if (adatok[i].Adoszam== megadott)
                {
                    Console.WriteLine($"{adatok[i].Utca} utca {adatok[i].Haz_szam}");
                    db++;
                }
            }
            if (db==0)
            {
                Console.WriteLine("Nem szerepel az adatállományban");
            }
            Console.ReadLine();
        }
    }
}
