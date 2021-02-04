/* jogo - cara ou coroa */

Random jogarMoeda = new Random();
int moeda = jogarMoeda.Next(0, 2);

Console.WriteLine((moeda == 0) ? "heads" : "tails");
Console.WriteLine($"{(moeda == 0 ? "heads" : "tails" )}");