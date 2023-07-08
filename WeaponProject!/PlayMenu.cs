using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WeaponProject_
{
    internal class PlayMenu
    {



        public static void Battle()
        {


            List<Weapon> weapons = new List<Weapon>()
            {
                new Bow(),
                new Gun(),
                new Gun(),
            };

            foreach (var weapon in weapons)
                Console.WriteLine(weapon);


            Player player = new Player();
            player.Weapon = weapons[0];

            Player player2 = new Player();
            player2.Weapon = weapons[1];


            // player = player + player2;

            Console.WriteLine(player);


            while (true)
            {
                Console.WriteLine("Ready");
                Thread.Sleep(500);
                Console.WriteLine("Steady");
                Thread.Sleep(500);
                Console.WriteLine("Bang!");
                Thread.Sleep(500);


                int dmg = player.Shoot();
                player2.HP -= dmg;
                player2.HP = player2.HP < 0 ? 0 : player2.HP;

                Console.WriteLine($"Player2 HP {player2.HP} DMG {dmg}");

                if (player2.HP <= 0)
                    break;

                Console.WriteLine("Ready");
                Thread.Sleep(500);
                Console.WriteLine("Steady");
                Thread.Sleep(500);
                Console.WriteLine("Bang!");
                Thread.Sleep(500);

                dmg = player2.Shoot();
                player.HP -= dmg;
                player.HP = player.HP < 0 ? 0 : player.HP;
                Console.WriteLine($"Player HP {player.HP} DMG {dmg}");

            }



        }

    }
}
