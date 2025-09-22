

using System.ComponentModel;
using System.Security.Cryptography;

public class Sensor
{
    private static double SerialNumber = 0.0; // Static field to keep track of serial numbers
    private string Name { get; set; }
    private double Value { get; set; }
    private string _qrId;

    public Sensor(string name, double value)
    {
        Name = name;
        Value = value;
        SerialNumber += 0.1; // Increment serial number for each new instance
        Console.WriteLine($"Sensor Created with Serial Number: {SerialNumber:F1}");
    }

    public Sensor()
    {
        Name = "DefaultSensor";
        Value = 0.0;
        SerialNumber += 0.1; // Increment serial number for each new instance
        Console.WriteLine($"Sensor Created with Serial Number: {SerialNumber:F1}");
    }

    public void GenerateQrId()
    {
        if (string.IsNullOrEmpty(_qrId))
        {
            _qrId = RandomNumberGenerator.GetInt32(100000, 999999).ToString();
        }
        else
        {
            Console.WriteLine("QR ID already generated.");
        }
    }

    public string GetQrId(){
        if (string.IsNullOrEmpty(_qrId))
        {
            Console.WriteLine("QR ID not generated yet.");
            _qrId = "";
        }


        return _qrId;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Sensor Name: {Name}, Sensor Value: {Value}");
    }
}

