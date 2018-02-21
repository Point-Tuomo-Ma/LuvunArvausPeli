using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuvunArvausPeli
{
    class Program
    {
       
        static void Main(string[] args)
        {   // Alustetaan pelin käyttämät muuttuja ja arvotaan arvattava luku
            List<int> arvatutLista = new List<int>();
            Random arvattavaLuku = new Random();
            int pelaajanLuku = 0;
            int kierrosLaskuri = 0;
            int arvottuLuku = arvattavaLuku.Next(1, 100);
            while (arvottuLuku != pelaajanLuku) // Kysytään käyttäjältä lukua kunnes hän syöttää oikean luvun.
            {
                Console.Write("Arvaa luku väliltä 1 - 100: ");
                pelaajanLuku = int.Parse(Console.ReadLine());
                kierrosLaskuri = kierrosLaskuri + 1; // Tallennetaan käyttäjän syöttämien arvausten lukumäärä.
                arvatutLista.Add(pelaajanLuku);
                if (pelaajanLuku > arvottuLuku)
                {
                    Console.WriteLine("Luku on pienenmpi kuin arvaamasi!");
                } else if (pelaajanLuku < arvottuLuku)
                {
                    Console.WriteLine("Luku on suurempi kuin arvaamasi!");
                }
            }
            Console.WriteLine("Arvasit oikein, onnittelut! Tarvitsit oikeaan lukuun " + kierrosLaskuri + " arvausta.");
            Console.WriteLine("Arvaamasi luvut ovat: ");
            for (int i = 0; i < arvatutLista.Count; i++)    // Tulostetaan käyttäjän syöttämät luvut.
            {
                Console.Write(arvatutLista[i] + " ");
            }
            Console.WriteLine("");
            Console.Write("Paina jotain lopettaaksesi.");
            Console.ReadLine();
{}
        }
        
    }
}
