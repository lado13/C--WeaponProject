using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponProject_
{
    internal class Gun : Weapon
    {
        public int BulletQuantity { get; set; }

        static Random rand = new Random();


        public Gun()
        {
            GenerateBulletQuantity();
            GenerateLethality();
            GeneratePower();
        }

        public void GenerateBulletQuantity()
        {
            BulletQuantity = rand.Next(1, 100);
        }



        public override void GeneratePower()
        {
            int min = Math.Min(BulletQuantity, Letality);
            int max = Math.Max(BulletQuantity, Letality);   
            Power = rand.Next(min, max);    
        }

        public override void GenerateLethality()
        {
            Letality = rand.Next(BulletQuantity, 100);   
        }

        public override string ToString()
        {
            return $"BulletQuantity {BulletQuantity}";
        }
    }
}
