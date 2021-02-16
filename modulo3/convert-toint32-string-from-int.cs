/*

converte cadeia de caracteres em int.

O método ToInt32() tem 19 versões sobrecarregadas que permitem que ele aceite praticamente todos os tipos de dados.
Então, quando devemos usar a classe Convert? A classe Convert é melhor para converter números fracionários em
números inteiros (int) porque ela arredonda da maneira esperada.


*/

string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);