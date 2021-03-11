/*

O objetivo desse código é  mesclará informações personalizadas dos clientes.
 
Para promover os produtos de investimento mais recentes da empresa, é preciso criar uma mesnsagem contendo
informações, como o portfólio existente, e comparará seus retornos atuais com retornos projetados se o cliente
precisar investir no uso dos nossos novos produtos.

Criar a saída formatada observando as variáveis com informaçoes do cliente e produto.

saida:

Dear Mr. Jones,
As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.

Currently, you own 2,975,000.00 shares at a return of 12.75 %.

Our new product, Glorious Future offers a return of 13.13 %.  Given your current volume, your potential profit would be ¤63,000,000.00.

Here's a quick comparison:

Magic Yield         12.75 %   ¤55,000,000.00      
Glorious Future     13.13 %   ¤63,000,000.00

*/

//Informações do cliente e produto.
string customerName = "Mr. Jones";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

//msg
Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:C} shares at a return of {currentReturn:P}.\n");
Console.WriteLine($"Our new product, {newProduct} offers a return de {newReturn:P}. Given your current volume, your potential profit would be {newProfit:C}.\n");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += String.Format($"{currentReturn:P}").PadRight(10);
//comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += String.Format($"{currentProfit:C}").PadRight(20);
//comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

comparisonMessage += "\n";

comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format($"{newReturn:P}").PadRight(10);
//comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format($"{newProfit:C}").PadRight(20);
//comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);


Console.WriteLine(comparisonMessage);