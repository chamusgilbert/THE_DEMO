using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Creator
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public Class Class { get; set; }
        public Stat S { get; set; }
        public Pouch MoneyBag { get; set; }
        public List<Obj> Inv { get; set; }

        public Creator()
        {
            Name = NameGen();
            Family = FamilyGen();
            Stat tempStat = StatGen();
            Class = new Class(tempStat);
            S = new Stat(tempStat.Str + Class.Bonus.Str, tempStat.Spd + Class.Bonus.Spd, tempStat.Lk + Class.Bonus.Lk, tempStat.Int + Class.Bonus.Int);
            Inv = InvGen();
        }
        private string NameGen()
        {
            Console.WriteLine("What is your first name");
            string n = Console.ReadLine();
            n = n.Substring(n.Length - 1, 1).ToUpper() + n.Substring(1, n.Length - 2).ToLower() + n.Substring(0, 1).ToLower();
            return n;
        }
        private string FamilyGen()
        {
            Console.WriteLine("What is your Last Name");
            string f = Console.ReadLine();
            char[] q = f.ToLower().ToCharArray();
            if (q[q.Length - 1] == 'a' || q[q.Length - 1] == 'e' || q[q.Length - 1] == 'i' || q[q.Length - 1] == 'o' || q[q.Length - 1] == 'u')
            {
                f = f + "tte";
            }
            else if (q[q.Length - 1] == 'd' || q[q.Length - 1] == 't' || q[q.Length - 1] == 'n' || q[q.Length - 1] == 'f' || q[q.Length - 1] == 'g')
            {
                f = f + "or";
            }
            else if (q[q.Length - 1] == 'm' || q[q.Length - 1] == 'l' || q[q.Length - 1] == 's' || q[q.Length - 1] == 'c' || q[q.Length - 1] == 'k')
            {
                f = f + "ite";
            }
            else if (q[q.Length - 1] == 'p' || q[q.Length - 1] == 'r' || q[q.Length - 1] == 'q' || q[q.Length - 1] == 'f' || q[q.Length - 1] == 'h')
            {
                f = f + "ell";
            }
            else
            {
                f = f.Substring(1);
            }
            return f;
        }
        private Stat StatGen()
        {
            int st = Stat.StrGen();
            int sp = Stat.SpdGen();
            int l = Stat.LkGen();
            int i = Stat.IntGen();
            Stat s = new Stat(st, sp, l, i);
            return s;
        }
        private List<Obj> InvGen()
        {
            string n;
            int d = 100;
            List<Obj> inv = new List<Obj>();
            Console.WriteLine("What is the weapon your holding?");
            n =Console.ReadLine();
            Obj o = new Obj(d, n);
            inv.Add(o);
            return inv;
        }
        private Pouch PouchGen(string t)
        {
            Pouch p = new Pouch();
            if (t.Contains("Royal"))
            {
                p.Gold += 100;
                p.Silver += 100;
                p.Copper += 100;
            }
            else if (t.Contains("Thief"))
            {
                p.Gold += 2;
                p.Silver += 13;
                p.Copper += 100;
            }
            else if (t.Contains("Knight"))
            {
                p.Silver += 10;
            }
            else if (t.Contains("Legend"))
            {
                p.Gold += 10;
            }
            else if (t.Contains("Monk"))
            {
            }
            else
            {
                p.Copper += 10;
            }
            return p;
        }
    }
}
