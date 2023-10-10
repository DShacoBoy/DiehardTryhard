using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace Ideelos
{
    public class Player
    {
        public int Level { get; private set; }
        public int Exp { get; private set; }
        public int Health { get; private set; }
        public int Defense { get; private set; }
        public int attackPower { get; private set; }


        public Player()
        {
            Level = 1;
            Exp = 0;
            Health = 100;
            Defense = 5;
            attackPower = 10;

        }

        public int attack()
        {
           return attackPower;
        }

        public void TakeDamage(int damage)
        {
            int totalDamage = Math.Max(0, damage - Defense);
            Health -= totalDamage;
            Console.WriteLine("Du nimmst " + totalDamage + " Schaden!");
        }

        public void GainExp(int exp)
        {
            Exp += exp;

            if (Exp >= Level * 10)
            {
                Level++;
                Exp = 0;
                Health += 50;
                Defense += 2;
                attackPower += 5;
                Console.WriteLine("Herzlichen Glückwunsch! Du bist auf Level " + Level + " aufgestiegen!");
            }
        }
    }
}
        
    
