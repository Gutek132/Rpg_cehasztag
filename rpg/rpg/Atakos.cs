using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace rpg
{
    internal class Atakos
    {
        public static void Ataki_info()
        {
            Console.WriteLine("Basic atak - atak za darmo więc bije mniej");
            Console.WriteLine("Shield - koszt 50 many, daje 100 shielda");
            Console.WriteLine("Combo - koszt 20 many, zadaje dmg 3 razy");
            Console.WriteLine("Wilk - koszt 30 many, atakujesz bardziej bo wilkiem");
        }
        //------------------------------------------------------------
        //hp shield atk mana gold
        public static (int[], int[]) Basic_atak(int[] character, int[] Owca)
        {
            if (character[1] > 0)
            {
                character[1] -= Owca[2];
            }
            else
            {
                character[0] -= Owca[2];
            }
            Owca[0] -= character[2];
            Thread.Sleep(900);
            Console.WriteLine($"Zadałeś {character[2]} dmg, a otrzymałeś {Owca[2]} dmg od Owcy");
            Console.WriteLine($"Owca ma teraz {Owca[0]} hp");
            character[3] += 10;
            return (character, Owca);
        }
        //------------------------------------------------------------
        public static int[] Shield(int[] character)
        {
            if (character[3] >= 50)
            {
                character[1] += 100;
                character[3] -= 50;
                Console.WriteLine("You gained 100 shield");
                return character;
            }
            else
            {
                Console.WriteLine("No mana");
            }
            return character;
        }
        //------------------------------------------------------------
        public static (int[], int[]) Combo(int[] character, int[] Owca)
        {
            if (character[3] >= 20)
            {
                character[3] -= 20;
                if (character[1] > 0)
                {
                    character[1] -= Owca[2];
                }
                else
                {
                    character[0] -= Owca[2];
                }
                Owca[0] -= character[2]*3;
                Thread.Sleep(900);
                Console.WriteLine($"Zadałeś {character[2]*3} dmg, a otrzymałeś {Owca[2]} dmg od Owcy");
                Console.WriteLine($"Owca ma teraz {Owca[0]} hp");
            }
            else
            {
                Console.WriteLine("No mana");
            }
            return (character, Owca);
        }
        //------------------------------------------------------------
        public static (int[], int[]) Wilk(int[] character, int[] Owca)
        {
            if (character[3] >= 30)
            {
                character[3] -= 30;
                if (character[1] > 0)
                {
                    character[1] -= Owca[2];
                }
                else
                {
                    character[0] -= Owca[2];
                }
                Random wilk_dmg = new Random();
                Owca[0] -= wilk_dmg.Next(30,50);
                Thread.Sleep(900);
                Console.WriteLine($"Owca ma teraz {Owca[0]} hp");
            }
            else
            {
                Console.WriteLine("No mana");
            }
            return (character, Owca);
        }
    }
}
