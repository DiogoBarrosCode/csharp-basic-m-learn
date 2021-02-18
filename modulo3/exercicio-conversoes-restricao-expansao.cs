/*

O desafio a seguir forçará você a entender as implicações da conversão cast de valores considerando
o impacto de conversões de restrição e expansão.

*/

int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

/* Trunca o valor resltante da divisão para ignorar os decimais*/
//decimal divideValue = (decimal)value1 / value2;
//int result1 = (int)divideValue;

/* Converte o valor arredondando o valor da divisão */
int result1 = Convert.ToInt32((decimal)value1 / value2);

/* Faz um cast arredondando o valor da divisão */
//int result1 = value1 / (int)value2;
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");


decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");


float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");