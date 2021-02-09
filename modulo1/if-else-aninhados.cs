/*

if - else aninhados.

O aninhamento nos permite colocar blocos de código dentro de blocos de código.

O primeiro if irá analisar a expressão booleana referente as nossas variáveis num1, num2 e num3.
Se for falsa o bloco de código interno que contém outro if-else aninhado não será executado,
direcionando para o bloco de código do comando else. Mas se for verdadeiro irá analisar as condições do if aninhado.

*/

int num1 = 5;
int num2 = 6;
int num3 = 5;

if ((num1 == num2) || (num2 == num3) || (num1 == num3))
{
    if ((num1 == num2) && (num2 == num3))
    {
        Console.WriteLine("Existem 3 números iguais!");
    }
    else
    {
        Console.WriteLine("Existem 2 números iguais!");
    }
}
else
{
    Console.WriteLine("Todos os números são diferentes!");
}