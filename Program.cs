using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gun<int> gun = new Gun<int>("Shootgun", 30, 99);
           
            var shooting = new Shooting<Gun<int>>();
            shooting.Shoot(gun);
        }
    }
}
