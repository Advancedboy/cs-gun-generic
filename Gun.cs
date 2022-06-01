using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_homework
{
    internal class Gun<T>
    {
        public string Name { get; private set; }
        public T ammo { get;  set; }
        public T heat { get;  set; }

        public Gun(string name, T ammo, T heat) { 
            Name = name;
            this.ammo = ammo;
            this.heat = heat;
        }

        public override string ToString()
        {
            return $"{Name}.";
        }
    }
}
