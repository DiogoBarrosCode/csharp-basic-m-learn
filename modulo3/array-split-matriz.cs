/*

Aqui utilizamos o método Split() disponível para variáveis do tipo cadeia de caracteres para
criar uma matriz de cadeias de caracteres. Usaremos a vírgula como o delimitador para dividir uma
cadeia de caracteres longa em cadeias de caracteres menores. Por fim, executaremos um loop em cada
elemento da nova matriz de cadeia de caracteres.

*/

string value = "abc123";
char[] valueArray = value.ToCharArray();

Array.Reverse(valueArray);

string result = String.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}