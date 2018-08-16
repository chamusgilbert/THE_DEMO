using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Run
    {
        public static void MainCharIntro()
        {
            Console.WriteLine(Program.MainCharacter.Name + " " + Program.MainCharacter.Family);
            Console.WriteLine(Program.MainCharacter.Class.Title);
            Console.WriteLine("Strength: " + Program.MainCharacter.S.Str);
            Console.WriteLine("Speed: " + Program.MainCharacter.S.Spd);
            Console.WriteLine("Luck: " + Program.MainCharacter.S.Lk);
            Console.WriteLine("Intelligence: " + Program.MainCharacter.S.Int);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
