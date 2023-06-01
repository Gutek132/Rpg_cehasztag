using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg
{
    internal class Run
    {
        static void Main(string[] args)
        {
            //hp shield atk mana gold 
            int[] character = { 200, 0, 10, 100, 20 };
            int sheep_count = 0;

            int Maxhp = character[0];
            int Maxmana = character[3];
            string[] atacks = { "shield", "combo", "wilk" };

            while (Character.zywot(character))
            {
                Informations.rounds(character, sheep_count);
                string inp = Console.ReadLine().ToLower();
                if (inp == "3")
                {
                    break;
                }
                switch (inp)
                {
                    case "1":
                        Console.WriteLine("Napotykasz owce");
                        Fighto.Walka(character);
                        sheep_count++;
                        int rndevent = Eventos.Event_gen();
                        Eventos.Event_wyb(rndevent, character, Maxhp, Maxmana);
                        break;
                    case "2":
                        Atakos.Ataki_info();
                        break;
                }
            }
            Console.WriteLine("---------------------");
            Console.WriteLine("  Umarłeś, no cóż");
            Console.WriteLine("---------------------");
            Console.ReadKey();
        }
    }
}
