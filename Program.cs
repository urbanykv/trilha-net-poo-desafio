using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new("11988888888", "C20", "123456789012345", 32);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Subway Surfer");

Iphone iphone = new("11999999999", "15 Pro Max", "123123456789789", 64);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
