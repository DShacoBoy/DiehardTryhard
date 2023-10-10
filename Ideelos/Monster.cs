using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ideelos
{
    abstract class monster
    {
        public string Name { get; private set; }
        public string Type { get; private set; }
        public int Health { get; private set; }
        public int Exp { get; private set; }
        public int Defense { get; private set; }
        public int AttackPower { get; private set; }

        public monster(string name, string type, int health, int exp, int defense, int attackPower)
        {
            Name = name;
            Type = type;
            Health = health;
            Exp = exp;
            Defense = defense;
            AttackPower = attackPower;
        }

        public int Attack()
        {
            Random random = new Random();
            return random.Next(AttackPower - 2, AttackPower + 2);
        }

        public virtual void TakeDamage(int damage)
        {
            Health -= damage;
            Console.WriteLine(" " + Name + " nimmt " + damage + " Schaden!");
        }
    }

    class Slime : monster
    {
        public Slime(string name)
            : base("Schleim", "Slime", 30, 10, 2, 5) { }

        public override void TakeDamage(int damage)
        {
            base.TakeDamage(damage);
            if (Health <= 0)
            {
                Console.WriteLine("Das " + Name + " ist tot!");
            }
        }
    }

    class Kobold : monster
    {
        public Kobold(string name)
            : base("Kobold", "Kobold", 50, 25, 5, 10) { }

        public override void TakeDamage(int damage)
        {
            base.TakeDamage(damage);
            if (Health <= 0)
            {
                Console.WriteLine("Der " + Name + " ist tot!");
            }
        }
    }

    class Goblin : monster
    {
        public Goblin(string name)
            : base("Goblin", "Goblin", 80, 45, 10, 15) { }

        public override void TakeDamage(int damage)
        {
            base.TakeDamage(damage);
            if (Health <= 0)
            {
                Console.WriteLine("Der " + Name + " ist tot!");
            }
        }
    }

    class Oger : monster
    {
        public Oger(string name)
            : base("Oger", "Oger", 150, 80, 25, 30) { }

        public override void TakeDamage(int damage)
        {
            base.TakeDamage(damage);
            if (Health <= 0)
            {
                Console.WriteLine("Der " + Name + " ist tot!");
            }
        }
    }

    class Wyvern : monster
    {
        public Wyvern(string name)
            : base(name, "Wyvern", 500, 200, 50, 80) { }
        public override void TakeDamage(int damage)
        {
            base.TakeDamage(damage);
            if (Health <= 0)
            {
                Console.WriteLine("Herzlichen Glückwunsch!");
                Console.WriteLine("Du hast den Boss" + Name + "besiegt!");
            }
        }
    }
}

