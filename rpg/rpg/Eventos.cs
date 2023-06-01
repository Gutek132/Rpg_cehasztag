using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace rpg
{
    internal class Eventos
    {
        public static int[] Karczma(int[] character, int Maxhp)
        {
            Console.WriteLine("Napotkałeś opuszczoną karczmę");
            Console.WriteLine("Co chcesz zrobić?");
            Console.WriteLine("1 - wylecz hp | 2 - mam gdzieś darmowy heal");
            string inp = Console.ReadLine().ToLower();
            switch (inp)
            {
                case "1":
                    character[0] = Maxhp;
                    Console.WriteLine("Hp wyleczone");
                    break;
                case "2":
                    Console.WriteLine("Aha");
                    break;
            }
            return character;
        }
        //---------------------------------
        public static int[] Kuglarz(int[] character)
        {
            Console.WriteLine("Napotkałeś kuglarza i możesz coś wylosować za 10 golda");
            Console.WriteLine("1 - wylosuj coś (-10golda) | 2 - nie, dziękuje");
            string inp = Console.ReadLine().ToLower();
            switch (inp)
            { 
                case "1":
                    if (character[4] > 0)
                    {
                    character[4] -= 10;
                    Random kuglarz_los1 = new Random();
                    int kuglarz_los = kuglarz_los1.Next(1, 5);
                    Kuglarz_losy(character, kuglarz_los);
                    }
                    else
                    {
                        Console.WriteLine("No gold");
                    }
                    break;
                case "2":
                    Console.WriteLine("Idziesz dalej");
                    break;
            }
            return character;
        }
        //---------------------------------
        public static int[] Kuglarz_losy(int[] character, int kuglarz_los)
        {
            switch (kuglarz_los)
            {
                case 1:
                    character[0] += 20;
                    Console.WriteLine("Trafiłeś +20 hp");
                    break;
                case 2:
                    character[0] -= 20;
                    Console.WriteLine("Trafiłeś -20 hp");
                    break;
                case 3:
                    character[3] += 20;
                    Console.WriteLine("Trafiłeś +20 many");
                    break;
                case 4:
                    character[3] -= 20;
                    Console.WriteLine("Trafiłeś -20 many");
                    break;
                case 5:
                    Console.WriteLine("Trafiłeś nic, gratuluję");
                    break;
            }
            return character;
        }
        //---------------------------------
        public static int[] Zrodlo(int[] character, int Maxmana)
        {
            Console.WriteLine("Napotkałeś losowe źródełko");
            Console.WriteLine("Co chcesz zrobić?");
            Console.WriteLine("1 - odnów manę | 2 - nie chce many za darmo");
            string inp = Console.ReadLine().ToLower();
            switch (inp)
            {
                case "1":
                    character[3] = Maxmana;
                    Console.WriteLine("Mana odnowiona");
                    break;
                case "2":
                    Console.WriteLine("Aha");
                    break;
            }
            return character;
        }
        //---------------------------------
        public static int Event_gen()
        {
            Random evento = new Random();
            int rndevent = evento.Next(1, 4);
            return rndevent;
        }
        public static int[] Event_wyb(int rndevent, int[] character, int Maxhp, int Maxmana)
        {
            switch (rndevent)
            {
                case 1:
                    Karczma(character, Maxhp);
                    break;
                case 2:
                    Kuglarz(character);
                    break;
                case 3:
                    Zrodlo(character, Maxmana);
                    break;
            }
            return character;
        }
    }
}
