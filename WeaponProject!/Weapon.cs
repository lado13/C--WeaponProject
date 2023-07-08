using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponProject_
{
    internal abstract class Weapon
    {
        public int Power { get; set; }
        public int Letality { get; set; }

        public abstract void GeneratePower();
        public abstract void GenerateLethality();

        public override string ToString()
        {
            return $"Power {Power} Letality {Letality}";
        }


    }
}
