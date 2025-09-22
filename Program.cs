// See https://aka.ms/new-console-template for more information
Sensor tempSensor = new Sensor("Temperature", 25);
tempSensor.DisplayInfo();
tempSensor.DisplayInfo();
Sensor pressureSensor = new Sensor("Pressure", 1.01);
pressureSensor.DisplayInfo();
var defaultSensor = new Sensor();
tempSensor.GenerateQrId();
pressureSensor.GenerateQrId();

var qrIDTempSensor = tempSensor.GetQrId();
var qrIDPressureSensor = pressureSensor.GetQrId();


