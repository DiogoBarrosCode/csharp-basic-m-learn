/* 
Na conversão de tipos implicita o compilador concatena dois tipos de dados inteiros
isso porque eles estão dentro de uma cadeia de caracteres.

Então converte implicitamente a variável int widgetsSold em um string temporariamente,
para que possa concatenar o restante da cadeia de caracteres.

 */


string firstName = "Bob";
int widgetsSold = 7;

Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");


/*
Neste caso, os parênteses de abertura e fechamento formam o operador de ordem de operações,

Indicamos que queremos que o parêntese mais interno seja resolvido primeiro, resultando
na adição de valores int``widgetsSold e no valor 7.

*/

Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");