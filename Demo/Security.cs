using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Security
    {
        public static void SecurityStore()
        {
            Console.WriteLine("Welcome to the Security Store");
            Console.WriteLine("You will need supplies to debug this computer");
            Console.WriteLine("Pick a key to bring along");
            string key = Console.ReadKey(true).Key.ToString();
            Console.WriteLine(key + "???");
            Console.WriteLine("That key is pretty expensive... well... I guess since you are going to save the Computer...");
            Console.WriteLine("Yeah... This one is on the house!");
            Program.MainCharacter.Inv.Add(new Obj(100, key));
        }
    }
}
