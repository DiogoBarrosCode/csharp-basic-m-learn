/* 
Do while - básico 

O bloco de código é executado uma vez e
depois a condição booliana é avaliada.

*/

Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
}while (current != 7);