/*

Operadores de incremento e decremento são executados de forma diferente quando
o operador está antes ou depois do operando. Dependendo de sua posição,
eles executam sua operação antes ou depois de recuperarem o valor.

*/


int value = 1;
//variável incrementada.
value ++;
//variavél recuperada.
Console.WriteLine("First: " + value);
//variável incrementada depois do valor só afetará a variável na próxima iteração.
Console.WriteLine("Second: " + value ++);
//variavél agora sim é incrementada pelo código anterior.
Console.WriteLine("Third: " + value);
//Aqui a variável é incrementada antes do valor, então será incrementada de imediato.
Console.WriteLine("Fourth: " + (++ value));