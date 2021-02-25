/*

Limpar itens da matriz.

Aqui, estamos usando o método Array.Clear() para limpar os valores armazenados nos elementos da matriz pallets começando no 
índice 0 e limpando 2 elementos.

Quando você usa Array.Clear(), os elementos que foram limpos não referenciam mais uma cadeia de caracteres na memória.
Os valores armazenados nos dois primeiros elementos da matriz foram limpos. Como podemos ver na propriedade Length e 
na instrução foreach, os elementos ainda existem, mas agora estão vazios.


*/

string[] pallets = {"B14", "A11", "B12", "A13"};
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}