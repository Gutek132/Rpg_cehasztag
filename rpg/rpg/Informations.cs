using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace rpg
{
    internal class Informations
    {
        public static void rounds(int[] character, int sheep_count)
        {
            //hp atk mana gold
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"Ilość zabitych owiec = {sheep_count}");
            Console.WriteLine($"Twoje HP - {character[0]} | Shield - {character[1]} | Attack - {character[2]} | MANA - {character[3]} | GOLD - {character[4]}");
            Console.WriteLine($" 1 - Walka | 2 - Opis ataków | 3 - Zakończ swój żywot przedwcześnie ");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
            Thread.Sleep(900);
        }
    }
}
