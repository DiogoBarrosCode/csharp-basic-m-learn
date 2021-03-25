/*

Recuperar qualquer valor entre um ou mais conjuntos de parênteses.

Desta vez o message terá três conjuntos de parênteses e escreveremos o código para extrair 
qualquer texto dentro deles. Precisaremos adicionar uma instrução while para iterar pela 
cadeia de caracteres até que todos os conjuntos de parênteses sejam descobertos, extraídos 
e exibidos.


*/


string message = "(What if) there are (more than) one (set of parentheses)?";

while (true)
{
    int openingPosition = message.IndexOf('(');
    if (openingPosition == - 1) break;

    openingPosition += 1;

    int closingPosition = message.IndexOf(')');
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

    message = message.Substring(closingPosition + 1);
}


/*

Saída:

What if
more than
set of parentheses

*/

