namespace OOP_Beispiel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

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

            Console.WriteLine("Car speed: " + car.Speed);
            Console.WriteLine("Car acceleration: " + car.Acceleration);
            Console.WriteLine("Car breakspeed: " + car.BreakSpeed);
            Console.WriteLine("Car doorcounter: " + car.Speed);
            car.LogInformation();

            Console.WriteLine("Plane speed: " + plane.Speed);
            Console.WriteLine("Plane acceleratioin: " + plane.Speed);
            Console.WriteLine("Plane doorcounter: " + plane.Speed);
            Console.WriteLine("Plane has Jetdrive: " + plane.HasJetDrive);
            plane.LogInformation();
        }
    }
}
