
/* A variável não é acessível fora do bloco de código no qual está definida.
Se tentarmos acessar fora do bloco de código retornará erro. */


/* Não acessa váriavél value fora do bloco de código */
bool flag = true;

if (flag)
{
    int value = 10;
    Console.WriteLine($"Inside of code block: {value}");
}
//Console.WriteLine($"Outside of code block: {value}");





/* Acessa váriavél value fora do bloco de código */
bool flag = true;
int value = 0;

if (flag)
{
    value = 10;
    Console.WriteLine($"Inside of code block: {value}");
}
Console.WriteLine($"Outside of code block: {value}");