﻿using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456",modelo: "Nokia",imei: "11111111",memoria: 64 );
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Apple");
Smartphone iphone = new Iphone(numero: "4987",modelo: "Iphone",imei: "22222222",memoria: 128 );
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");