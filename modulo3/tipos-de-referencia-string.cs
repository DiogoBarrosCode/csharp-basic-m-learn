/*

O tipo de dados string também é um tipo de referência. Mas não usamos o operador new ao declarar uma cadeia de caracteres.
Como o tipo de dados string é usado com frequência, em segundo plano, no entanto, uma nova instância de System.String é 
criada e inicializada.

 Isso é meramente uma conveniência proporcionada pelos designers do C#.


*/

string msg = "Hello World!";
Console.WriteLine(msg);