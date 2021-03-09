/*

A formatação composta usa espaços reservados numerados dentro de uma cadeia de caracteres.
Em tempo de execução, tudo dentro das chaves será resolvido para um valor que também é passado com base em sua posição.

1.	A cadeia de caracteres literal "{0} {1}!" forma um modelo, partes das quais serão substituídas em tempo de execução. 
2.	O token {0} é substituído pelo primeiro argumento depois do modelo da cadeia de caracteres;
em outras palavras, o valor da variável first. 
3.	O token {1} é substituído pelo segundo argumento depois do modelo da cadeia de caracteres;
em outras palavras, o valor da variável second.


*/


string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);