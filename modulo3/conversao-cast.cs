/*

Conversão Cast

Para executar uma conversão cast, use o operador de conversão cast () para envolver um tipo de dados
e colocá-lo ao lado da variável que você deseja converter.

*/


decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");