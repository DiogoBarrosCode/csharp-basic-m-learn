/*
Operador ternário -
Se a compra for maior que 1000 o desconto será 100,
mas se a compra foi igual a 1000 ou menor o desconto será 50.
*/

int saleAmount = 1001;

int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");

//Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");