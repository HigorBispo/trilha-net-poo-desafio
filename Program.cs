using DesafioPOO.Models;
// TODO: Realizar os testes com as classes Nokia e Iphone


// Instaciando o Nokia
Console.WriteLine("Teste Nokia:");
Smartphone nokia = new Nokia(numero: "123456789", modelo: "Nokia 3310", imei: "123456789012345", memoria: 16);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");


Console.WriteLine("\n"); // Apenas para separar os testes no console


//Instanciar o Iphone
Console.WriteLine("Teste Iphone:");
Smartphone iphone = new Iphone(numero: "654321987", modelo: "Iphone 13", imei: "543210987654321", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");