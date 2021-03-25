/*

Trabalhar com tipos diferentes de conjuntos de símbolos.

Desta vez, atualizaremos a cadeia de caracteres message adicionando tipos diferentes de símbolos, 
como colchetes e chaves. Dependeremos de IndexOfAny() para fornecer uma matriz de caracteres que 
representa os símbolos de abertura. IndexOfAny() retornará a primeira correspondência encontrada 
na cadeia de caracteres.

Quando um símbolo for encontrado, precisaremos localizar seu símbolo de fechamento correspondente. 
pois de fazer isso, o restante deve ser semelhante. Usaremos uma tática diferente em vez de 
modificar o valor original de message. Desta vez, usaremos a posição de fechamento da iteração 
anterior como a posição de abertura da iteração atual.

*/


string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

char[] openSymbols = {'[', '{', '('};

int closingPosition = 0;

while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;

    string currentSymbols = message.Substring(openingPosition, 1);

    char matchingSymbol = ' ';

    switch (currentSymbols)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

}


/*

Saída:

What if
different symbols
open symbol
matching closing symbol

*/