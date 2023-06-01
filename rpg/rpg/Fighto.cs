using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg
{
    internal class Fighto
    {
        public static int[] GenOwca()
        {
            Random rnd = new Random();
            int[] Owca_Stats = new int[4];
            for (int i = 0; i < Owca_Stats.Length; i++)
            {
                Owca_Stats[i] = rnd.Next(20, 30);
            }
            Owca_Stats[0] += 20;
            return Owca_Stats;
        }
        //-----------------------------------------------------
        public static int[] Walka(int[] character)
        {
            int[] Owca = GenOwca();
            while ((Owca[0] > 0) && ((Character.zywot(character))))
            {
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine($"Owca ma {Owca[0]} hp");
                Console.WriteLine($"Co robisz? Masz {character[0]} hp, {character[1]} shielda i {character[3]} many");
                Console.WriteLine("1 - Basic atak (+10many) | 2 - Shield (-50many) | 3 - Combo (-20many) | 4 - Wilk (-30many)");
                string atak_wyb = Console.ReadLine().ToLower();
                switch ( atak_wyb ) 
                {
                    case "1":
                        Atakos.Basic_atak(character, Owca);
                        break;
                    case "2":
                        Atakos.Shield(character);
                        break;
                    case "3":
                        Atakos.Combo(character, Owca);
                        break;
                    case "4":
                        Atakos.Wilk(character, Owca);
                        break;
                }
            }
            return character;
        }
    }
}
