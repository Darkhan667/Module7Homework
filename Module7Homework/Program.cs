using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;


namespace Module7Homework
{
    
    public class Tank
    {

        public string Name { get; set; }
        public int AmmoAmount { get; set; }
        public int ArmourLevel { get; set; }
        public int MobilityLevel { get; set; }
        public Tank()
        {

        }
        public Tank(string Name, int AmmoAmount, int ArmourLevel, int MobilityLevel)
        {
            this.Name = Name;
            this.AmmoAmount = AmmoAmount;
            this.ArmourLevel = ArmourLevel;
            this.MobilityLevel = MobilityLevel;
        }
        
        
        public static Tank operator *(Tank T34, Tank Panther)
        {
            if (T34.AmmoAmount > Panther.AmmoAmount && T34.ArmourLevel > Panther.ArmourLevel)
                return T34;
            if (T34.MobilityLevel > Panther.MobilityLevel && T34.AmmoAmount > Panther.AmmoAmount)
                return T34;
            if (T34.MobilityLevel > Panther.MobilityLevel && T34.ArmourLevel > Panther.ArmourLevel)
                return T34;
            else
                return Panther;
            

        }
        public string Print()
        {
            Console.WriteLine("Tank that won: " + Name);
            Console.WriteLine("Ammo amount: " + AmmoAmount);
            Console.WriteLine("Armour level: " + ArmourLevel);
            Console.WriteLine("Mobility level: " + MobilityLevel);
            
            Console.WriteLine("-----------------------------------");

            return " ";
        }
        
    }
    
    class Program
    {
       
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Tank[] Dominater = new Tank[5];
            Tank[] T34 = new Tank[5];
            Tank[] Panther = new Tank[5];

            for (int i = 0; i < 5; i++)
            {
                T34[i] = new Tank("T34", rnd.Next(0, 100), rnd.Next(0, 100), rnd.Next(0, 100));
            }

            for (int i = 0; i < 5; i++)
            {
                Panther[i] = new Tank("Panther", rnd.Next(0, 100), rnd.Next(0, 100), rnd.Next(0, 100));
            }

            for (int i = 0; i < 5; i++)
            {
                Dominater[i] = T34[i] * Panther[i];
                Console.WriteLine(Dominater[i].Print());
            }
        }
    }
}
