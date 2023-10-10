using Ideelos;
using System;
using System.Collections.Concurrent;
using System.Dynamic;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Threading;



class Program
{
    static void Main()
    {
        Player player = new Player();
        monster currentMonster = new Slime("Slime");

        Console.WriteLine("Tryhard/Diehard");
        Console.WriteLine("---------------");


        while (true)
        {
            Console.WriteLine("Du bist Level " + player.Level + " mit " + player.Exp + " Erfahrungspunkte.");
            Console.WriteLine("Ein schwaches Monster erscheint und hat " + currentMonster.Health + " Gesundheit!");

            currentMonster = new Slime("Slime");
            {
                

                

                if (player.Level >= 15 && player.Level < 20 && !(currentMonster is Oger))
                {
                    currentMonster = new Oger("Oger");
                    Console.WriteLine("Vorsicht ein Oger erscheint");
                }
                if (player.Level >= 5 && player.Level < 10 && !(currentMonster is Kobold))
                {
                    currentMonster = new Kobold("Kobold");
                    Console.WriteLine("Kobold! Das tötet man zum Frühstück!");
                }
                if (player.Level >= 10 && player.Level < 15 && !(currentMonster is Goblin))
                {
                    currentMonster = new Goblin("Goblin");
                    Console.WriteLine("Ha ein Goblin! Zeit fürs Training.");
                }
                if (player.Level < 5 && !(currentMonster is Slime))
                {
                    currentMonster = new Slime("Slime");
                    Console.WriteLine("Ein lausiges Slime erscheint!");

                }
                if (player.Level >= 20 && player.Level < 21 && !(currentMonster is Wyvern))
                {
                    currentMonster = new Wyvern("Wyvern");
                    Console.WriteLine("ACHTUNG EIN BOSS ERSCHEINT!!!");


                }
                if (player.Level >= 21 && !(currentMonster is null))
                {
                    currentMonster = null;
                    Console.WriteLine("Herzlichen Glückwunsch! Du hast das Spiel gewonnen.");
                    Console.ReadLine();
                }
            }

            while (player.Health > 0 && currentMonster.Health > 0)
            {
                Console.WriteLine("Was möchtest du tun?");
                Console.WriteLine("1. Angreifen");
                Console.WriteLine("2. Fliehen");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    int damage = player.attack();
                    Console.WriteLine("Du greifst das Monster an und verursachst " + damage + " Schaden!");
                    currentMonster.TakeDamage(damage);


                   

                    if (currentMonster.Health > 0)
                    {
                        damage = currentMonster.Attack();
                        Console.WriteLine("Das Monster greift dich an und verursacht " + damage + " Schaden!");
                        player.TakeDamage(damage);
                    }
                }
                else if (choice == 2 && !(currentMonster is null))
                {
                    currentMonster = null;
                    Console.WriteLine("Du fliehst erfolgreich!");
                    Console.ReadLine();
                }
            }

            if (player.Health <= 0)
            {
                Console.WriteLine("Du bist gestorben! Game Over.");  // Falls du das sehen magst änder einfach den AttackPower Wert von irgendeinem Monster.
                Console.ReadLine();
            }

            Console.WriteLine("Du besiegst das Monster und erhältst " + currentMonster.Exp + " Erfahrungspunkte!");
            player.GainExp(currentMonster.Exp);

           


           
            
        }
    } 
}

    

       


