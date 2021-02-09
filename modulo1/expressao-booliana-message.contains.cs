/*

Uma expressão booliana pode ser o resultado de um método que retorna o valor true ou false.
Por exemplo, este é um exemplo de código simples que usa o método string.Contains()
para avaliar se uma cadeia de caracteres contém outra.

Como retorna um valor de true ou false, message.Contains("fox") se qualifica como uma expressão booliana
e pode ser usado em uma instrução if.

*/

string message = "The quick brown fox jumps over the lazy dog.";
bool result = message.Contains("dog");
Console.WriteLine(result);

if(message.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
}