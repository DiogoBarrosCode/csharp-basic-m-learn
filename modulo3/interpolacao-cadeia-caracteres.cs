/*

A interpolação de cadeia de caracteres é uma técnica mais recente que simplifica a formatação composta.

Em vez de usar um token numerado e incluir o valor literal ou nome da variável em uma lista de argumentos
em String.Format() ou Console.WriteLine(), você pode apenas usar o nome da variável dentro das chaves.

Para que uma cadeia de caracteres seja interpolada, você deve prefixá-la com a diretiva $.


*/


string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!");