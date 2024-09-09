using DesafioPOO.Models;

Smartphone iphone = new Iphone("11997473097", "iPhone 12 Pro Max", "45645736346464563", 256);
iphone.InstalarAplicativo("X");
iphone.Ligar();

Smartphone nokia = new Nokia("11943458891", "Nokia Startak", "465198465416741", 64);
nokia.InstalarAplicativo("X");
nokia.InstalarAplicativo("Telegram");
nokia.ReceberLigacao();