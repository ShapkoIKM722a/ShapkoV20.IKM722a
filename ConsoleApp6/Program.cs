
using System;

public class Phone
{

    private string brand;
    private string model;
    private string color;
    private double screenSize;
    private int batteryCapacity;


    public Phone(string brand, string model, string color, double screenSize, int batteryCapacity)
    {
        this.brand = brand;
        this.model = model;
        this.color = color;
        this.screenSize = screenSize;
        this.batteryCapacity = batteryCapacity;
    }


    public void DisplayInfo()
    {
        Console.WriteLine($"Brand: {brand}");
        Console.WriteLine($"Model: {model}");
        Console.WriteLine($"Color: {color}");
        Console.WriteLine($"Screen Size: {screenSize} inches");
        Console.WriteLine($"Battery Capacity: {batteryCapacity} mAh");
    }


    public void TurnOn()
    {
        Console.WriteLine($"{brand} {model} is turning on...");

    }


    public void Call(string phoneNumber)
    {
        Console.WriteLine($"Calling {phoneNumber}...");

    }
}
class Program
{
    static void Main(string[] args)
    {

        Phone myPhone = new Phone("Apple", "iPhone 13", "Space Gray", 6.1, 3095);


        myPhone.DisplayInfo();


        myPhone.TurnOn();


        myPhone.Call("123-456-7890");
    }
}

