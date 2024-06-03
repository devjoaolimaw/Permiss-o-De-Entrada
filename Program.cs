using System;

Console.WriteLine("Qual sua idade? ");
int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Possui permissão caso menor de idade? ");
string permissão = Console.ReadLine();
bool ehMaiorDeIdade = idade >= 18;
bool possuiAutorizacaoDoResponsavel = permissão == "sim";

if (ehMaiorDeIdade)
{
    Console.WriteLine("Entrada liberada!");
}
else if (possuiAutorizacaoDoResponsavel)
{
    Console.WriteLine("Entrada liberada!");
}
else
{
    Console.WriteLine("Entrada não liberada");
}
