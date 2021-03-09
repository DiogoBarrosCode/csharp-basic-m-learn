/*

Formatar percentuais

Use o especificador de formato P para formatar percentuais. Adicione um número posteriormente para
controlar o número de valores exibidos após o ponto decimal.

*/

decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P}");

Console.WriteLine("");

decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P3}");