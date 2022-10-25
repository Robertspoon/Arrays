using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays");
            Console.WriteLine();

            //0 Pistol
            //1 Atom disintegrator
            //2 Laser rifle
            //3 very big gun
            //4 Trench gun

           
            int weapon = 0; 

            string[] weaponName;
            weaponName = new string[5];
            weaponName[0] = "Pistol";
            weaponName[1] = "A.D.";
            weaponName[2] = "Laser rifle";
            weaponName[3] = "V.B.G.";
            weaponName[4] = "Trench gun";

            int[] ammo; 
            ammo = new int[5];
            ammo[0] = 6;
            ammo[1] = 2;
            ammo[2] = 25;
            ammo[3] = 3;
            ammo[4] = 5;

            int[] damage;
            damage = new int[5];
            damage[0] = 35;
            damage[1] = 300;
            damage[2] = 15;
            damage[3] = 250;
            damage[4] = 100;

            string[] Description;
            Description = new string[5];
            Description[0] = "Trusty side-arm";
            Description[1] = "Weapon of mass destruction";
            Description[2] = "High power laser rifle";
            Description[3] = "Very Big Gun";
            Description[4] = "Powerful shotgun useful for close combat";



            Console.WriteLine("Current weapon: " + weaponName[weapon]);
            Console.WriteLine("Ammo: " + ammo[weapon]);
            Console.WriteLine("Damage: " + damage[weapon]);
            Console.WriteLine("Description: " + Description[weapon]);
            Console.WriteLine();
            weapon = 1;
            Console.WriteLine("Current weapon: " + weaponName[weapon]);
            Console.WriteLine("Ammo: " + ammo[weapon]);
            Console.WriteLine("Damage: " + damage[weapon]);
            Console.WriteLine("Description: " + Description[weapon]);
            Console.WriteLine();
            weapon = 2;
            Console.WriteLine("Current weapon: " + weaponName[weapon]);
            Console.WriteLine("Ammo: " + ammo[weapon]);
            Console.WriteLine("Damage: " + damage[weapon]);
            Console.WriteLine("Description: " + Description[weapon]);
            Console.WriteLine();
            weapon = 3;
            Console.WriteLine();
            Console.WriteLine("Current weapon: " + weaponName[weapon]);
            Console.WriteLine("Ammo: " + ammo[weapon]);
            Console.WriteLine("Damage: " + damage[weapon]);
            Console.WriteLine("Description: " + Description[weapon]);
            Console.WriteLine();
            weapon = 4;
            Console.WriteLine();
            Console.WriteLine("Current weapon: " + weaponName[weapon]);
            Console.WriteLine("Ammo: " + ammo[weapon]);
            Console.WriteLine("Damage: " + damage[weapon]);
            Console.WriteLine("Description: " + Description[weapon]);
            Console.WriteLine();


            Console.ReadKey(true);
        }
        
    }
}

