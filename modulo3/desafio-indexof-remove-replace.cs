/*

Neste desafio, você trabalhará com uma cadeia de caracteres que contém um fragmento de HTML. 
você extrairá dados do fragmento HTML, substituirá parte de seu conteúdo e removerá outras partes.

Dado o ponto de partida na lista de códigos a seguir, você adicionará código para extrair, substituir
e remover partes do valor input para produzir a saída desejada.


Saída:

Quantity: 5000
Output: <h2>Widgets &reg;</h2><span>5000</span>

Operações

Defina a variável quantity como o valor extraído entre as marcas <span> e </span>.
Defina a variável output como o valor de entrada e, em seguida, remova as marcas <div> e </div>.
Substitua o caractere HTML &trade; por &reg; na variável output.



*/


string input = "<div class='product'><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

const string spanTag = "<span>";

// Extract the quantity
int quantityStart = input.IndexOf(spanTag);
int quantityEnd = input.IndexOf("</span>");
quantityStart += spanTag.Length;
int quantityLength = quantityEnd - quantityStart;
quantity = input.Substring(quantityStart, quantityLength);

// Set output to input, replacing the trademark symbol with the registered trademark symbol
output = input.Replace("&trade;", "&reg;");

// Remove the opening <div> tag
int divStart = input.IndexOf("<div");
int divEnd = input.IndexOf(">");
int divLength = divEnd - divStart;
divLength += 1;
output = output.Remove(divStart, divLength);

// Remove the closing <div> tag
int divCloseStart = output.IndexOf("</div");
int divCloseEnd = output.IndexOf(">", divCloseStart);
int divCloseLength = divCloseEnd - divCloseStart;
divCloseLength += 1;
output = output.Remove(divCloseStart, divCloseLength);

Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");


/*

Saída:

Quantity: 5000
Output: <h2>Widgets &reg;</h2><span>5000</span>

*/