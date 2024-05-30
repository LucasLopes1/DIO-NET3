using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("11999999999", "Tijolão", "123456789", 2);
nokia.Ligar();
nokia.InstalarAplicativo("Chrome");

Console.WriteLine("\n");

Console.WriteLine("iPhone");
Smartphone iphone = new Iphone("11999999999", "X pro", "123456789", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");