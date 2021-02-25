/*

Redimensionar a matriz para adicionar mais elementos.

Concentre-se na linha Array.Resize(ref pallets, 6);
Aqui, estamos chamando o método Resize() passando a matriz pallets por referência, usando a palavra-chave ref.

Nesse caso, estamos redimensionando a matriz pallets de quatro elementos para 6. Os novos elementos são 
adicionados ao final dos elementos atuais. Os dois novos elementos serão nulos até atribuirmos um valor a eles.


*/

string[] pallets = {"B14", "A11", "B12", "A13"};
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}