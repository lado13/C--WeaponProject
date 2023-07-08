using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponProject_
{
    internal class Bow : Weapon
    {
        public int Accuracy { get; set; }
        public int ArrowQuantity { get; set; }

        static Random rand = new Random();



        public Bow()
        {
            GenerateAccurancy();
            GenerateArrowQuantity();
            GeneratePower();
            GenerateLethality();
        }

        public void GenerateAccurancy()
        {
            Accuracy = rand.Next(1,100);    
        }

        public void GenerateArrowQuantity()
        {
            ArrowQuantity = rand.Next(1,Accuracy);   
        }

        public override void GeneratePower()
        {
            int min = Math.Min(Accuracy, ArrowQuantity);
            int max = Math.Max(Accuracy, ArrowQuantity);
            Letality = rand.Next(min, max);  
        }

        public override void GenerateLethality()
        {
            int min = Math.Min(Accuracy, ArrowQuantity);
            int max = Math.Max(Accuracy, ArrowQuantity);
            Power = rand.Next(min, max);    
        }

        public override string ToString()
        {
            return base.ToString() + $"Accuracy {Accuracy} ArrowQTY {ArrowQuantity}";
        }
    }
}
