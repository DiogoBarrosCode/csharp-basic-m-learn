/*

Conversão de expansão.
Significa que você está tentando converter um valor de um tipo de dados que poderia armazenar menos informações
 em um tipo de dados que pode armazenar mais informações.

Exemplo: converter um int em um decimal.

Como qualquer valor int pode se ajustar facilmente dentro de um decimal, o compilador executa a conversão implicita.


*/


int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");