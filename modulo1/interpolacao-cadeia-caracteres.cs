/*
A interpolação de cadeia de caracteres combina vários valores em uma única
cadeia de caracteres literal usando um "modelo" e uma ou mais expressões
de interpolação. Uma expressão de interpolação é uma variável cercada por
um símbolo de chave de abertura e fechamento {}. A cadeia de caracteres
literal se torna um modelo quando ele é prefixado pelo caractere $.
*/

string firstname = "Bob";
string greeting = "Hello";

Console.WriteLine($"{greeting} {firstname}!");