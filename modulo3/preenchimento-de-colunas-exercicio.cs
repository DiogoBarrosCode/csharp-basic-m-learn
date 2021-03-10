/*

Trabalhar com cadeias de caracteres preenchidas.

Vamos supor que trabalhamos para uma empresa de processamento de pagamentos,
Geralmente, esses sistemas exigem que os dados sejam inseridos em colunas específicas.
Por exemplo, a ID do pagamento deve ser armazenada nas colunas 1 a 6, o nome do favorecido
nas colunas 7 a 30 e o valor do pagamento nas colunas 31 a 40. 
Além disso, é importante que o Valor do Pagamento esteja alinhado à direita.


*/

string paymentID = "769";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formattedLine = paymentID.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine(formattedLine);


/*

Saída:

769   Mr. Stephen Ortega       $5,000.00


O código expressa as regras citadas.

1.	O pagamento terá 6 colunas adicionando um PadRight(6) a variável.
2.	O nome do beneficiário terá 24 colunas “PadRight(24)” ou seja da coluna 7 até a coluna 30.
3.	O valor do pagamento da coluna 31 a 40 alinhado a direita com PadLeft(10).
4.	Todos os valores são concatenados a variável formattedLine.

*/