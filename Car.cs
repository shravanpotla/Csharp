using System;
ElectricCar e = new ElectricCar(4, 4, 75);
e.ShowDetails();
class Vehicle
{
    public int Wheels;
    public Vehicle(int wheels)
    {
        Wheels = wheels;
        Console.WriteLine("Vehicle ctor");
    }
}
class Car : Vehicle
{
    public int Doors;
    public Car(int wheels, int doors) : base(wheels)
    {
        Doors = doors;
        Console.WriteLine("Car ctor");
    }
}
class ElectricCar : Car
{
    public int BatteryKwh;
    public ElectricCar(int wheels, int doors, int batteryKwh)
        : base(wheels, doors)
    {
        BatteryKwh = batteryKwh;
        Console.WriteLine("ElectricCar ctor");
    }
    public void ShowDetails()
    {
        Console.WriteLine($"Wheels: {Wheels}, Doors: {Doors}, Battery: {BatteryKwh}");
    }
}