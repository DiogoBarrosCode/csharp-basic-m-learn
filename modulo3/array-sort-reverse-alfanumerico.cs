/*

Concentre-se na linha de código Array.Reverse(pallets);
Aqui, estamos usando o método Reverse() da classe Array para inverter a ordem dos itens.

*/

string[] pallets = {"B14", "A11", "B12", "A13"};

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}