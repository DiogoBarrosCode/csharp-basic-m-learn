/*

No exemplo a seguir, o especificador de formato de moeda :C
é usado para apresentar as variáveis price e discount como moeda.

Se você executasse esse código em um computador nos EUA com o Idioma de Exibição do Windows definido como inglês
veria a seguinte saída.

Price: $123.45 (Save $50.00)

E se você executar o código em um computador na França que tem o Idioma de Exibição do Windows definido como francês?
Nesse caso, você veria a seguinte saída.

Price: 123,45 € (Save 50,00 €)

Formatar valores para exibição podem ser consideradas uma linguagem e cultura específicas.
O uso desses recursos de formatação de cadeia de caracteres dependem da cultura computacional.
Nesse contexto, o termo “cultura” refere-se ao país e ao idioma do usuário final.

*/

decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");