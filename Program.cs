using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
System.Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia (numero: "00111112222", modelo: "Modelo X", imei: "000111222", memoria: "64");

nokia.Ligar();
nokia.InstalarAplicativo("Nokia Tunes");

System.Console.WriteLine("===================================");

System.Console.WriteLine("Smartphone IPhone");

Smartphone iphone = new Iphone (numero: "00111113333", modelo: "Modelo I", imei: "000333222", memoria: "128");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("ITunes");