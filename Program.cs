using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");

Nokia nokia = new Nokia(numero: "123", modelo: "PEDRA", imei: "001020011", memoria: 8);
nokia.Ligar();
nokia.InstalarAplicativo("Ligue of Legends: Wild rift");

Console.WriteLine("Smartphone Iphone:");

Iphone iphone = new Iphone(numero: "454465789", modelo: "Roxo", imei: "15601100", memoria: 512);
iphone.Ligar();
iphone.InstalarAplicativo("Mobile Legends)";
