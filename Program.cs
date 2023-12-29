using DesafioPOO.Models;




System.Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero:"9999 9999", modelo: "Iphone", imei: "IMEI123",memoria: 120);
nokia.Ligar();
//nokia.ReceberLigacao();
nokia.InstalarAplicativo("YouTube");

System.Console.WriteLine("\n");

System.Console.WriteLine("Smartphone IPhone:");
Smartphone iphone = new Iphone( numero:"88888 88888", modelo: "nokia", imei: "IMEI123",memoria: 64);
//iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");


