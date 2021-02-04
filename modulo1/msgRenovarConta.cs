Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if ((daysUntilExpiration <= 10) && (daysUntilExpiration >= 6))
{
    Console.WriteLine("Your subscription will expire soon.  Renew now!");
}
else if ((daysUntilExpiration <= 5) && (daysUntilExpiration >= 2))
{
    Console.WriteLine("Your subscription expires in " + daysUntilExpiration + " days.");
    discountPercentage += 10;
    Console.WriteLine("Renew now and save " + discountPercentage + "%!");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage += 20;
    Console.WriteLine("Renew now and save " + discountPercentage + "%!");
}
if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}