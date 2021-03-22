/*

Vamos escrever um código para recuperar o conteúdo dentro do último conjunto de parênteses.

O segredo deste exemplo é o uso de LastIndexOf(), que usamos para obter as posições dos 
últimos parênteses de abertura e fechamento.

*/


string message = "(What if) I am (only interested) in the last (set of parentheses)?";

int openingPosition = message.LastIndexOf('(');

openingPosition += 1;

int closingPosition = message.LastIndexOf(')');
int length = closingPosition - openingPosition;

Console.WriteLine(message.Substring(openingPosition, length));

