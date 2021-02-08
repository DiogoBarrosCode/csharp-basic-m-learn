/*

Programa para converter graus Fahrenheit em celsius.

Para converter temperaturas de graus Fahrenheit para Celsius, primeiro subtraia 32 e,
em seguida, multiplique por cinco nonos (5/9).

*/

int fahrenheit = 94;
decimal celsius = (fahrenheit - 32) * (5m / 9m);

Console.WriteLine("The temperature is " + celsius + " Celsius");


/* outra opção de código seria. */

/*

int fahrenheit = 94;
decimal multiFactor = 5.0m / 9;
decimal celsius = (fahrenheit - 32) * multiFactor;

Console.WriteLine("The temperature is " + celsius + " Celsius");

*/