/*

Os caracteres de pipe duplo || são o operador lógico OR, que basicamente afirma que "a expressão à minha esquerda OU
a expressão à minha direita precisa ser verdadeira para que toda a expressão booliana seja verdadeira".
Se as duas expressões boolianas forem falsas, a expressão booliana inteira será falsa.

O código avalia três números se alguma condição for verdadeira toda expressão será verdadeira
e executará o bloco de código IF.

Para que toda expressão seja falsa todas as condições devem ser falsas. Executando o bloco de código ELSE.

*/

int num1 = 8;
int num2 = 5;
int num3 = 10;

if ((num1 == num2) || (num2 == 3) || (num1 == num3))
{
    Console.WriteLine("Você tem 2 números iguais!");
}
else
{
    Console.WriteLine("Você não tem números iguais!");
}