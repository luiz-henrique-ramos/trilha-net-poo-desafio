using DesafioPOO.Models;
using System;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("SmartPhone Nokia");

Smartphone n1 = new Nokia(numero: "997568417", modelo: "1", imei:  "123456789", memoria: 100);
n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("Whatsapp");

Console.WriteLine("SmartPhone Iphone");

Smartphone i1 = new Iphone(numero: "997568417", modelo: "2", imei: "123456789", memoria: 100);
i1.Ligar();
i1.ReceberLigacao();
i1.InstalarAplicativo("Instagram");