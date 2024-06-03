# Permiss-o-De-Entrada

Este código é um programa simples em C# que solicita a idade do usuário e verifica se ele pode entrar em algum lugar com base nessa idade e se possui permissão caso seja menor de idade.

1. Solicitação da idade:
```csharp
Console.WriteLine("Qual sua idade? ");
int idade = Convert.ToInt32(Console.ReadLine());
```
Nesta parte, o programa solicita ao usuário que insira sua idade e armazena o valor digitado na variável `idade`.

2. Verificação da permissão:
```csharp
Console.WriteLine("Possui permissão caso menor de idade? ");
string permissão = Console.ReadLine();
bool ehMaiorDeIdade = idade >= 18;
bool possuiAutorizacaoDoResponsavel = permissão == "sim";
```
O programa então pergunta ao usuário se ele possui permissão caso seja menor de idade e armazena a resposta na variável `permissão`. Em seguida, duas variáveis booleanas são definidas com base nas condições: `ehMaiorDeIdade` é `true` se a idade for maior ou igual a 18, e `possuiAutorizacaoDoResponsavel` é `true` se a resposta do usuário for "sim".

3. Verificação da entrada:
```csharp
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
```
Nesta parte, o programa verifica as condições para permitir a entrada. Se a pessoa for maior de idade (`ehMaiorDeIdade` é `true`), a entrada é liberada. Se não, mas ela possuir autorização do responsável (`possuiAutorizacaoDoResponsavel` é `true`), a entrada também é liberada. Caso contrário, a entrada não é liberada.

Em resumo, este código solicita a idade do usuário e verifica se ele pode entrar em algum lugar com base na idade e na permissão do responsável, se necessário. Ele fornece feedback ao usuário sobre a liberação ou não da entrada.
