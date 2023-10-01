using DesafioPOO.Models;

Console.WriteLine("Smathphone Nokia");
Smartphone nokia = new Nokia(numero: "519888777666", modelo: "XYP511", imei: "25zs5888wsd555", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("-----------------------");

Console.WriteLine("Smathphone Nokia");
Smartphone iphone = new Iphone(numero: "519666555444", modelo: "12", imei: "000ptf5478s5s5", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");