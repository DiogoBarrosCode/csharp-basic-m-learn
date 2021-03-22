/*

Métodos auxiliares IndexOf() e Substring() 

O método IndexOf() localiza a posição de uma cadeia de caracteres dentro de uma cadeia de caracteres maior.
Depois de localizar a posição usamos o método Substring() para retornar o restante da cadeia de caracteres após a posição. 

Agora que temos os dois índices utilizamos o método Substring() os definindo como limite para recuperar o valor.
O método Substring() precisa da posição inicial e do número de caracteres, ou comprimento, para recuperar.

Portanto, calculamos o comprimento em uma variável temporária chamada length e a passamos com o valor openingPosition para
recuperar a cadeia de caracteres dentro dos parênteses.

No entanto, a saída inclui o parêntese de abertura. Nessa situação em particular, isso não é desejado. Para corrigir isso,
precisaremos atualizar o código openingPosition += 1;

Ao aumentar a openingPosition em (1), você ignora o caractere de parêntese de abertura.
Se estivéssemos tentando localizar um valor iniciado após uma cadeia de caracteres mais longa, por exemplo,
<div> usaríamos o comprimento dessa cadeia (5) de caracteres em vez de (1).



*/


string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

openingPosition += 1;

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));


/*

string message = "What is the value <span>between the tags</span>?";

int openingPosition = message.IndexOf("<span>");
int closingPosition = message.IndexOf("</span>");

openingPosition += 6;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

*/