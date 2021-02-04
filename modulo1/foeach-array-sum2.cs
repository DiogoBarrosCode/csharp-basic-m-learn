/** instrução foreach para criar uma soma de todos os itens + o resultado de cada interação. **/

int[] inventory = {200, 450, 700, 175, 250};
int sum = 0;
int bin = 0;

foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}

Console.WriteLine($"WE have {sum} items in inventory.");