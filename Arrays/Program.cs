﻿using System;
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

            //current weapon
            int weapon = 0; //0..4

            string[] weaponName;
            weaponName = new string[5];
            weaponName[0] = "Pistol";
            weaponName[1] = "A.D.";
            weaponName[2] = "Laser rifle";
            weaponName[3] = "V.B.G.";
            weaponName[4] = "Trench gun";

            //ammo


            int[] ammo; //array of integers; declaration
            ammo = new int[5];// ubstantiation
            ammo[0] = 6;//pistol
            ammo[1] = 2;
            ammo[2] = 25;
            ammo[3] = 3;
            ammo[4] = 5;

            // show current weapon (without hardcoding)
            Console.WriteLine(weaponName[weapon]);
            Console.WriteLine(ammo[weapon]);
            weapon = 3;
            Console.WriteLine(weaponName[weapon]);
            Console.WriteLine(ammo[weapon]);

            Console.ReadKey(true);
        }
        static void ShowCurrentWeaponAmmo()
        {

        }
    }
}
