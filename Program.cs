using DesafioPOO.Models;


Smartphone nokia = new Nokia(numero: "00 91234-5678", modelo:"AB1234-5", imei:"000000000000000", memoria: 32);
Smartphone iphone = new Iphone(numero: "00 9876-54321", modelo: "CD6789-0", imei:"111111111111111", memoria: 64);

Console.WriteLine("\n** TESTE NOKIA: **\n");
nokia.Ligar(iphone.Numero);
nokia.InstalarAplicativo("Instagram");
nokia.Especificacoes();

Console.WriteLine("\n** TESTE IPHONE: **\n");
iphone.ReceberLigacao(nokia.Numero);
iphone.InstalarAplicativo("Facebook");
iphone.Especificacoes();

Console.WriteLine("\n** Atualizando número de telefone: **");
iphone.MudarNumero("22 9098-7234");
iphone.Especificacoes();
Console.WriteLine();




