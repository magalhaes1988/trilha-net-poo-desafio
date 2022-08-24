using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia(numero: "11987654321", modelo: "N95", imei: "1234567891022", memoria: 64);
Smartphone iphone = new Iphone(numero: "18965473215", modelo: "iPhone 13", imei:"98765432101236", memoria:512);

Console.WriteLine("Smartphone Nokia");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");
Console.WriteLine("Smartphone iPhone");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Canvas");

