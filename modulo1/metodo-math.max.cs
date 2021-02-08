/*

Use um método da classe System.Math para determinar qual dos dois números é maior.
Chamar um método da classe Math que aceitará dois valores e retornará o maior deles na variável largerValue, 
que será impressa no console.

É possível usar o IntelliSense ou o docs.microsoft.com para encontrar o método e descobrir como chamá-lo corretamente.

*/


int firstValue = 500;
int secondValue = 600;
int largerValue;

largerValue = Math.Max(firstValue, secondValue);
Console.WriteLine(largerValue);

/*

O método Math.Max() é compatível com 11 versões sobrecarregadas para aceitar diferentes tipos de dados.
A versão sobrecarregada do método Math.Max() que chamamos aceitará int como os dois parâmetros de entrada e
retornará o maior dos dois valores como um int.

*/