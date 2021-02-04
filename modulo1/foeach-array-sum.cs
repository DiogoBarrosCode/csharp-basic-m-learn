/** instrução foreach para criar uma soma de todos os itens **/

int[] inventory = {200, 450, 700, 175, 250};
int sum = 0;

foreach (int items in inventory)
{
    sum += items;
}

Console.WriteLine($"WE have {sum} items in inventory.");