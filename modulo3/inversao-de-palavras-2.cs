/*

Desafio de código.

Escreva o código necessário para inverter as letras de cada palavra no lugar e exibir o resultado.
Em outras palavras, não basta inverter todas as letras na variável pangram. Em vez disso, você precisará inverter
apenas as letras de cada palavra, mas imprimir a palavra invertida na posição original na mensagem.

saída: ehT kciuq nworb xof spmuj revo eht yzal god

*os comentarios no código testam algumas funcionalidades

*/

string pangram = "The quick brown fox jumps over the lazy dog";

string[] message = pangram.Split(' ');
/*
foreach(var msg in message)
{
    Console.WriteLine($"-- {msg}");
}
*/

string[] newMessage = new string[message.Length];
//Console.WriteLine($"-- {message.Length}");

for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
       /*
        foreach(var l in letters)
        {
            Console.WriteLine($"-- {l}");
        }
        */
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

string result = String.Join(" ", newMessage);
Console.WriteLine(result);