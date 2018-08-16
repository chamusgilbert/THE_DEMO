using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        public static Creator MainCharacter;

        static void Main(string[] args)
        {
            MainCharacter = new Creator();
            Run.MainCharIntro();
            Security.SecurityStore();

        }

    }
}
