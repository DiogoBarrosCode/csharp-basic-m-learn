/*

Desafio para dividir os dados dependendo do seu tipo e a concatenar ou adicionar os dados de forma adequada.

Dados: "12.3", "45", "ABC", "11", "DEF".

Dica: Iterar por meio de cada valor em uma cadeia de caracteres de valores.

Regras de negócio:

Regra 1: se o valor for alfanumérico, concatene-o para formar uma mensagem

Regra 2: se o valor for numérico, adicione-o ao total

Regra 3: verifique se o resultado corresponde à seguinte saída:

Message: ABCDEF
Total: 68.3


*/

string[] values = {"12.3", "45", "ABC", "11", "DEF"};
decimal result = 0m;
decimal total = 0;
string message = "";

foreach(string valores in values )
{
    if (decimal.TryParse(valores, out result))
    {
        total += result;
    }
    else
    {
        message += valores;
    }

}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");


/* Outra solução possivel */

/*
string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal total = 0m;
string message = "";

foreach (var value in values)
{
    decimal number;
    if (decimal.TryParse(value, out number))
    {
        total += number;
    } else
    {
        message += value;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");
*/