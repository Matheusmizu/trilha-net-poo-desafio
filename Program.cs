using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "modelo3110", imei: "11111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "6789", modelo: "modelo11promax", imei: "2222222", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

