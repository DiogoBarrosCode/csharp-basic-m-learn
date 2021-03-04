/*

Aqui estamos usando o método ToCharArray() para criar uma matriz de char.
Cada elemento da matriz tem um caractere da cadeia de caracteres original.

*/

string value = "abc123";
char[] valueArray = value.ToCharArray();

foreach (var values in valueArray)
{
    Console.WriteLine($"-- {values}");
}