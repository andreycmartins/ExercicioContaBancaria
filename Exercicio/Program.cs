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
    Console.Write("Entre o depósito do valor inicial: ");
    double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    conta = new ContaBancaria(numero, titular, depositoInicial);
}
else
{
    conta = new ContaBancaria(numero, titular);
}

Console.WriteLine("Dados da conta");
Console.Write(conta);
