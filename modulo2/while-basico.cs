/*

while - básico

No loop while a expressão é avaliada antes de entrar no bloco de código se for 
false o bloco de código não será executado, mas se for true a cada execução a 
expressão será avaliada novamente até que a expressão seja false e saia do loop.

*/


Random random = new Random();
int current = random.Next(1, 11);

while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");