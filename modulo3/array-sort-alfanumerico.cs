/*

Concentre-se na linha de código Array.Sort(pallets);.
Aqui, estamos usando o método Sort() da classe Array para classificar os itens na matriz de forma alfanumérica.

*/


string[] pallets = {"B14", "A11", "B12", "A13"};

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}