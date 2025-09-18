// See https://aka.ms/new-console-template for more information
Sensor tempSensor = new Sensor("Temperature", 25);
tempSensor.DisplayInfo();
tempSensor.Value = 24.0;
tempSensor.DisplayInfo();
Sensor pressureSensor = new Sensor("Pressure", 1.01);
pressureSensor.DisplayInfo();
Console.WriteLine("Hello, World!");

public class Sensor
{
    private static double SerialNumber = 0.0; // Static field to keep track of serial numbers
    public string Name { get; set; }
    public double Value { get; set; }

    public Sensor(string name, double value)
    {
        Name = name;
        Value = value;
        SerialNumber += 0.1; // Increment serial number for each new instance
        Console.WriteLine($"Sensor Created with Serial Number: {SerialNumber:F1}");
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Sensor Name: {Name}, Sensor Value: {Value}");
    }
}



