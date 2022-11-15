// See https://aka.ms/new-console-template for more information
using FactoryPatternVehicles;

Console.WriteLine("Hello, World!");
{
    int WheelCount;
    bool input = false;
    do
    {

        Console.WriteLine("Enter the amount of tires for the vehicle you want to create");
        int wheelCount;
        input = int.TryParse(Console.ReadLine(), out wheelCount);


    } while (!input);

    int numOfWheels = 0;
    var vehicle = VehicleFactory.GetVehicle(numOfWheels);
    vehicle.Drive();
}
    

    

    





