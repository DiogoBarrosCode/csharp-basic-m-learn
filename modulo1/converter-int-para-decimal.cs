/*

Para converter int em decimal, você adiciona o operador de conversão antes do valor.
Use o nome do tipo de dados entre parênteses na frente do valor para convertê-lo.
Neste caso, adicionaríamos (decimal) antes das variáveis first e second.

*/


int first = 7;
int second = 5;

decimal quotient = (decimal)first / (decimal)second;

Console.WriteLine(quotient);