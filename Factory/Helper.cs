public class Vehicle
{
    public int wheels;

    public void PrintWheels()
    {
        System.Console.WriteLine(this.wheels);
    }
}

public class Car : Vehicle
{
    public Car()
    {
        this.wheels = 4;
    }
}

public class Bike : Vehicle
{
    public Bike()
    {
        this.wheels = 2;
    }
}

public static class VehicleFactory
{
    public static Vehicle GetVehicle(string type)
    {
        if (type == "car")
        {
            return new Car();
        }
        else
        {
            return new Bike();
        }
    }
}