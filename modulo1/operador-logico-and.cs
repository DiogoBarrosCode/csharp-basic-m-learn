/*

Os caracteres de E comercial duplos && são o operador lógico AND, que basicamente afirma que 
"somente se duas as expressões forem verdadeira, a expressão inteira será verdadeira".
Nesse caso, se num1 for igual a num2, e num2 for igual a num3, por dedução, num1deverá ser igual a num3
e o usuário teve um resultado triplicado.

Se for verdadeiro será executado o bloco de códigos da instrução if.

Se for falso será executado o bloco de códigos da instrução else.

*/

int num1 = 5;
int num2 = 5;
int num3 = 5;

if ((num1 == num2) && (num2 == num3))
{
    Console.WriteLine("Você tem 3 números iguais!");
}
else
{
    Console.WriteLine("Você não tem 3 números iguais!");
}