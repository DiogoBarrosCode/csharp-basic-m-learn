/*

Desafio de código.

Escreva o código necessário para inverter as letras de cada palavra no lugar e exibir o resultado.
Em outras palavras, não basta inverter todas as letras na variável pangram. Em vez disso, você precisará inverter
apenas as letras de cada palavra, mas imprimir a palavra invertida na posição original na mensagem.

saída: ehT kciuq nworb xof spmuj revo eht yzal god

*os comentarios no código testam algumas funcionalidades

*/


string pangram = "The quick brown fox jumps over the lazy dog";

char[] pangramArray = pangram.ToCharArray();
/*
foreach(var teste1 in pangramArray){
    Console.WriteLine($"--{teste1}");
}
*/

Array.Reverse(pangramArray);
/*
foreach(var teste2 in pangramArray){
    Console.WriteLine($"--{teste2}");
}
*/

string resultPangramArray = new string(pangramArray);
//Console.WriteLine($"{resultPangramArray}");

string[] itemsPangram = resultPangramArray.Split(' ');
/*
foreach(var teste3 in itemsPangram){
    Console.WriteLine($"--{teste3}");
}
*/

Array.Reverse(itemsPangram);
/*
foreach(var teste4 in itemsPangram){
    Console.WriteLine($"--{teste4}");
}
*/

string result = String.Join(" ", itemsPangram);
Console.WriteLine(result);