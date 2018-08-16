using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Class
    {
        public Stat Bonus { get; set; }
        public string Title { get; set; }

        public Class(Stat stat)
        {
            Title = TitleGen(stat);
            Bonus = BonusCalc(Title);
        }
        private string TitleGen(Stat s)
        {
            string t, c;
            if (s.Spd > 9)
            {
                t = "Holy ";
            }
            else if (s.Str > 9)
            {
                t = "Legend ";
            }
            else if (s.Int > 8)
            {
                t = "Master ";
            }
            else if (s.Lk > 9)
            {
                t = "Royal ";
            }
            else
            {
                t = "";
            }
            if (s.Int > 6)
            {
                if (s.Str > 6 && s.Spd < 7)
                {
                    c = "Knight";
                }
                else if (s.Spd > 6 && s.Str < 7)
                {
                    c = "Ninja";
                }
                else if (s.Lk > 5)
                {
                    c = "Wizard";
                }
                else
                {
                    c = "Outlaw";
                }
            }
            else if (s.Int < 4)
            {
                c = "Monk";
            }
            else
            {
                if (s.Str > 6 && s.Spd < 7)
                {
                    c = "Warrior";
                }
                else if (s.Spd > 6 && s.Str < 7)
                {
                    c = "Thief";
                }
                else if (s.Lk < 8)
                {
                    c = "Mage";
                }
                else
                {
                    c = "Monk";
                }
            }
            return t + c;
        }
        private Stat BonusCalc(string t)
        {
            int st = 0, sp = 0, l = 0, i = 0;
            if (t.Contains("Ninja"))
            {
                sp += 2;
            }
            if (t.Contains("Warrior"))
            {
                st += 1;
            }
            if (t.Contains("Thief"))
            {
                sp += 1;
            }
            if (t.Contains("Knight"))
            {
                st += 2;
            }
            if (t.Contains("Mage"))
            {
                i += 1;
            }
            if (t.Contains("Wizard"))
            {
                i += 2;
            }
            if (t.Contains("Monk"))
            {
                l += 2;
            }
            if (t.Contains("Holy"))
            {
                sp += 2;
                st += 2;
                l += 2;
                i += 2;
            }
            if (t.Contains("Legend"))
            {
                sp += 1;
                st += 1;
                l += 1;
                i += 1;
            }
            if (t.Contains("Master"))
            {
                sp += 1;
                st += 1;
                l += 1;
                i += 2;
            }
            if (t.Contains("Royal"))
            {
                sp -= 1;
                l += 2;
                i += 1;
            }
            if (t.Contains("Outlaw"))
            {
                st -= 2;
                sp -= 2;
                l -= 2;
                i += 1;
            }
            Stat s = new Stat(st, sp, l, i);
            return s;
        }

    }
}
