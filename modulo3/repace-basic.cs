/*

Replace()

Usaremos o método Replace() para substituir um ou mais caracteres por um caractere diferente (ou nenhum caractere).
O método Replace() é diferente dos outros métodos que usamos até agora, pois ele substituirá todas as instâncias 
dos caracteres especificados, e não apenas a primeira ou a última instância.

Aqui, usamos o método Replace() duas vezes. Na primeira vez, substituímos a cadeia de caracteres -- por um espaço vazio.
Na segunda vez, substituímos a cadeia de caracteres - por uma cadeia de caracteres vazia, que remove completamente
o caractere da cadeia de caracteres.

*/


string message = "This--is--ex-amp-le--da-ta";

message = message.Replace("--", " ");
message = message.Replace("-", "");

Console.WriteLine(message);



/*

Saída:

This is example data


*/