/*

O método int.TryParse() retornará true se ele tiver convertido com êxito nossa string de variável value em um int;
caso contrário, ele retornará false.

Evolvendo a instrução em uma instrução if conseguimos fazer um controle.
Quando o valor for convertido será armazenado no int da variável result. 

A palavra-chave out instrui o compilador de que o método TryParse()não retornará apenas um valor
mas será populado pelo parâmetro out, podendo ser usado posteriormente em seu código.

*/

string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}


Console.WriteLine($"Measurement (w/ offset): {50 + result}");


/*

outro cenário com TryParse() recebendo um valor que não pode ser convertido.

*/

/*
string value = "bad";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}

if (result > 0)
    Console.WriteLine($"Measurement (w/ offset): {50 + result}");
*/