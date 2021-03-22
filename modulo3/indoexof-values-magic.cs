/*
Evitar valores mágicos.

As cadeias de caracteres codificadas como "<span>" na lista de códigos são conhecidas como 
"cadeias de caracteres mágicas" e valores numéricos codificados como 6 são conhecidos como "números mágicos". 
Os valores "mágicos" são indesejáveis por vários motivos e você deve tentar evitá-los, se possível.
*/

string message = "What is the value <span>between the tags</span>?";

int openingPosition = message.IndexOf("<span>");
int closingPosition = message.IndexOf("</span>");

openingPosition += 6;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));


/*

Se você errar a digitação uma vez como "<sapn>". O compilador não detectará isso em tempo de compilação.
Além disso, se você alterar a cadeia de caracteres "<span>" para "<div>", mas esquecer de alterar o número 6,
o código produzirá resultados indesejáveis.

Em vez disso, você deve usar uma constante com a palavra-chave const. Uma constante permite definir e
inicializar uma variável cujo valor nunca pode ser alterado.

*/

string message2 = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition2 = message2.IndexOf(openSpan);
int closingPosition2 = message2.IndexOf(closeSpan);

openingPosition2 += openSpan.Length;

int length2 = closingPosition2 - openingPosition2;
Console.WriteLine(message2.Substring(openingPosition2, length2));