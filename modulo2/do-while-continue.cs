/*

do while - continue

Ao executar o código você não verá nenhum valor 8 ou maior na janela de saída antes que a 
execução do código termine com o valor 7. Como você pode ver, continue ignorará a execução da 
iteração atual para que nada maior que 7 seja impresso.

*/


Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);