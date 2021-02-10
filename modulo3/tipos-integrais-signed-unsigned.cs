/*

Tipos integrais com sinal.
Um tipo com sinal usa seus bytes para representar uma quantidade igual de números positivos e negativos.

Tipos integrais sem sinal.
Um tipo sem sinal usa seus bytes para representar apenas números positivos.

O código utiliza o MinValue e MaxValue para expor os intervalos de valores para os vários tipos de dados integrais com e sem sinal.

*/

Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte   : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short   : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int     : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long    : {long.MinValue} to {long.MaxValue}");

Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte     : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort   : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint     : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong    : {ulong.MinValue} to {ulong.MaxValue}");