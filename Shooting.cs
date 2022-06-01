using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_homework
{
    internal class Shooting<T>
        where T : Gun<int>
    {
        public void Shoot(T gun)
        {
            Console.WriteLine($"Shooting from {gun}.");
            
            for (int i = 0; i < gun.ammo; i++)
            {
                Console.WriteLine("Pow!");
                Console.WriteLine($"{i} rounds left...");
                Console.WriteLine("Reloading");
            }
        }
    }
}
