/*

Pequeno teste de cast.

Com base nisso, posso ver que a conversão cast de um decimal em um float
é uma conversão de restrição, pois estou perdendo precisão.

*/

decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float  : {myFloat}");