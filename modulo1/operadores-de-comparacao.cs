/*

Operadores de comparação.

utilizado numa expressão booliana para retornar se uma comparação entre dois valores é verdadeira ou falsa.

1 ==, o "operador igual" para testar a igualdade
2 >, o "operador maior que", para testar se o valor à esquerda é maior que o valor à direita
3 <, o "operador menor que", para testar se o valor à esquerda é menor que o valor à direita
4 >= o "operador maior que ou igual a"
5 <= o "operador menor que ou igual a"
6 != o "operador é deferente de"

*/

int num = 10;

bool igualdade = num == 10;
Console.WriteLine(igualdade);

bool maiorQue = num > 10;
Console.WriteLine(maiorQue);

bool menorQue = num < 100;
Console.WriteLine(menorQue);

bool maiorIgual = num >= 9;
Console.WriteLine(maiorIgual);

bool menorIgual = num <= 9;
Console.WriteLine(menorIgual);

bool diferente = num != 10;
Console.WriteLine(diferente);