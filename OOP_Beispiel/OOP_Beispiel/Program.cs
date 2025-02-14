namespace OOP_Beispiel
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car()
            {
                Speed = 100,
                Acceleration = 10,
                BreakSpeed = 50,
                DoorCounter = 4
            };

            Plane plane = new Plane();
            plane.Speed = 250;
            plane.Acceleration = 50;
            plane.DoorCounter = 2;
            plane.HasJetDrive = true;

            Helicopter  heli = new Helicopter();
            heli.Speed = 250;
            heli.Acceleration = 50;
            heli.DoorCounter = 2;

            Motorcycle motorcycle = new Motorcycle();
            motorcycle.Speed = 120;
            motorcycle.Acceleration = 40;


            List<Vehicle> list = new List<Vehicle>();
            list.Add(car);
            list.Add(motorcycle);
            list.Add(plane);
            list.Add(heli);

            Console.WriteLine("Welches Fahrzeug möchtest du benutzen?");
            var userInput = Console.ReadLine();

            foreach (Vehicle vehicle in list)
            {
                if (vehicle.GetType().Name == userInput)
                {
                    Console.WriteLine("Fahrzeug gefunden: " + userInput);

                    vehicle.LogInformation();

                    if (userInput == "Car")
                    {
                        Car myCar = vehicle as Car;
                        myCar.Move();

                    } else if (userInput == nameof(Motorcycle))
                    {
                        Motorcycle myBike = vehicle as Motorcycle;
                        myBike.Move();

                    } else if (userInput == nameof(Plane))
                    {
                        Plane myPlane = vehicle as Plane;
                        myPlane.Move();
                        myPlane.Landing();

                    } else if (userInput == "Helicopter")
                    { 
                        Helicopter myHelicopter = vehicle as Helicopter;
                        myHelicopter.Move();
                        myHelicopter.Landing();

                    } else
                    {
                        Console.WriteLine("Dieses Fahrzeug steht nicht bereit.");
                    }

                        break;
                }
            }
        }
    }
}
