/*

Com Array.Reverse() invertemos os elementos da matriz e a expressão new string(valueArray) cria uma instância vazia 
da classe System.String (que é a mesma do tipo de dados string em C#) e passa a matriz char como um construtor.

*/

string value = "abc123";
char[] valueArray = value.ToCharArray();

Array.Reverse(valueArray);
string result = new string(valueArray);
Console.WriteLine(result);