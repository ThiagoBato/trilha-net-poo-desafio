using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone -->");
Smartphone iphone = new Iphone(numero: "99999999", modelo: "Modelo 01", imei: "XXXXXXXXXX", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("Facebook");
Console.WriteLine("--------------------");
Console.WriteLine("Smartphone Nokia -->");
Smartphone nokia = new Nokia(numero: "99999999", modelo: "Modelo 02", imei: "XXXXXXXXXX", memoria: 512);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");