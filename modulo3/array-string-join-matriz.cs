/*

Talvez seja necessário separar cada elemento da matriz char usando uma vírgula.
Usaremos o método Join() da classe String, passando o char que desejamos para delimitar
cada segmento (a vírgula) e a própria matriz.

*/

string value = "abc123";
char[] valueArray = value.ToCharArray();

Array.Reverse(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);