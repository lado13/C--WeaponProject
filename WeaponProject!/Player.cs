using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponProject_
{
    internal class Player
    {
        public string PlayerName { get; set; }
        public Weapon Weapon { get; set; }
        public int HP { get; set; } = 100;

        public int Shoot()
        {
            return Weapon.Power;
        }

        public override string ToString()
        {
            return $"HP {HP}";
        }
    }
}
