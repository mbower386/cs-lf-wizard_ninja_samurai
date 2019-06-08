using System;
using WizardNinjaSamurai.HumanClass;

namespace WizardNinjaSamurai.NinjaClass
{
    class Ninja : Human
    {
        public Ninja (string name, int str, int intel, int hp) : base (name, str, intel, 175, hp)
        {

        }

        public override int Attack (Human target)
        {
            int extraDmg = 10;
            int dmg = Dexterity * 5;
            target.Health -= dmg;

            Random rand = new Random ();
            int randNum = rand.Next (0, 100);
            if (randNum > 80)
            {
                target.Health -= extraDmg;
            }

            Console.WriteLine ($"{Name} attacked {target.Name} for {dmg + extraDmg} damage!");

            return target.Health;
        }

        public void Steal (Human target)
        {
            target.Health -= 5;
            Health += 5;
        }
    }
}