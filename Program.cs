using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("40028922", "model1", "98959856", 128);
nokia.Ligar();
nokia.InstalarAplicativo("appLoja2");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone("32281516", "gs", "854644", 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("appLoja1");