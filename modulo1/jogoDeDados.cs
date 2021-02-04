Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total} pts.");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
	if ((roll1 == roll2) && (roll2 == roll3))
	{
		Console.Write("You rolled triples! +6 bonus!");
		total +=6;
        Console.WriteLine(" to total = " + total + " pts.");
	}
	else
	{
		Console.Write("You rolled doubles! +2 bonus!");
		total +=2;
        Console.WriteLine(" to total = " + total + " pts.");
	}
}

if (total >= 15)
{
    Console.WriteLine("You win!");
}
else
{
    Console.WriteLine("Sorry, you lose.");
}