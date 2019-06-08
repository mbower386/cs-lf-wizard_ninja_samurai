using System;
using WizardNinjaSamurai.HumanClass;

namespace WizardNinjaSamurai.WizardClass
{
    class Wizard : Human
    {
        public Wizard (string name, int str, int dex) : base (name, str, 25, dex, 50)
        {

        }

        public override int Attack (Human target)
        {
            int dmg = Intelligence * 5;

            target.Health -= dmg;

            Health += dmg;
            Console.WriteLine ($"{Name} attacked {target.Name} for {dmg} damage!");

            return target.Health;
        }

        public void Heal (Human target)
        {
            target.Health += 10 * Intelligence;

            Console.WriteLine ($"{Name} healed {target.Name} for {10 * Intelligence} health!");
        }
    }

}