// See https://aka.ms/new-console-template for more information
Sensor tempSensor = new Sensor("Temperature", 25);
tempSensor.DisplayInfo();
tempSensor.Value = 24.0;
tempSensor.DisplayInfo();
Sensor pressureSensor = new Sensor("Pressure", 1.01);
pressureSensor.DisplayInfo();
Console.WriteLine("Hello, World!");



