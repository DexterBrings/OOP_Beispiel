using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Beispiel
{
    abstract class Vehicle
    {
        //Properties
        public float Speed { get; set; }
        public float Acceleration { get; set; }
        public float BreakSpeed { get; set; }
        public int DoorCounter { get; set; }

        //Methode
        public void LogInformation()
        {
            Console.WriteLine("Das Fahrzeug hat eine Geschwindigkeit von " + Speed + " km/h.");
        }
    }
}
