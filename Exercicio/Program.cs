using Exercicio;
using System.Globalization;

ContaBancaria conta;

Console.Write("Entre com o número da conta: ");
int numero = int.Parse(Console.ReadLine());
Console.Write("Entre com o titular da conta: ");
string titular = Console.ReadLine();
Console.Write("Haverá depósito inicial: (s/n) ");
char resp = char.Parse(Console.ReadLine());

if (resp == 'S' || resp == 's')
{
    Console.Write("Entre o valor inicial da conta: ");
    double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    conta = new ContaBancaria(numero, titular, depositoInicial);
}
else
{
    conta = new ContaBancaria(numero, titular);
}

Console.WriteLine("Dados da conta");
Console.Write(conta);

Console.WriteLine();
Console.Write("Entre um valor para depósito: ");
double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Deposito(deposito);

Console.WriteLine("Dados da conta atualizados");
Console.Write(conta);

Console.WriteLine();
Console.Write("Entre com um valor para saque: ");
double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Saque(saque);

Console.WriteLine("Dados da conta atualizados");
Console.Write(conta);