// See https://aka.ms/new-console-template for more information
using SistemaIngressoExpressFestivalCidade;

Console.WriteLine("Hello, World!");


ClienteFestival clienteJorge = new ClienteFestival();


Console.WriteLine("Nome: ");
clienteJorge.NomeFa = Console.ReadLine();

Console.WriteLine("Quantos dias de Show: ");

clienteJorge.QtdDias = int.Parse(Console.ReadLine());


Console.WriteLine("Cupom Desconto: ");

clienteJorge.CDesconto = Console.ReadLine();


Console.WriteLine("Tem pontuação do clube de fidelidades: ");

clienteJorge.PontosClube = int.Parse(Console.ReadLine());


Console.WriteLine(clienteJorge.NomeFa.ToUpper());


Console.WriteLine(clienteJorge.CalculaBruto());

Console.WriteLine(clienteJorge.CalculaLiquido());

Console.WriteLine($"cesso ao Lounge VIP (true/false): {clienteJorge.QtdDias >= 2}");