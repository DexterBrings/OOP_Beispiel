using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Beispiel
{
    abstract class Vehicle
    {
        public float Speed { get; set; }
        public float Acceleration { get; set; }
        public float BreakSpeed { get; set; }
        public int DoorCounter { get; set; }
    }
}
