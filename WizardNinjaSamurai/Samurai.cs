using System;
using WizardNinjaSamurai.HumanClass;

namespace WizardNinjaSamurai.SamuraiClass
{
    class Samurai : Human
    {
        public Samurai (string name, int str, int intel, int dex) : base (name, str, intel, dex, 200)
        {

        }

        public override int Attack (Human target)
        {
            int dmg = Strength * 5;
            target.Health -= dmg;

            if (target.Health < 50)
            {
                target.Health = 0;
            }

            Console.WriteLine ($"{Name} attacked {target.Name} for {dmg} damage!");

            return target.Health;
        }

        public void Meditate ()
        {
            Health = 100;
        }
    }
}