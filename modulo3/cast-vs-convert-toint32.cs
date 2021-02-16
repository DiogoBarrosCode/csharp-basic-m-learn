/*

cast vs Convert.ToInt32();

Então, quando devemos usar a classe Convert? A classe Convert é melhor para converter números fracionários
em números inteiros (int) porque ela arredonda da maneira esperada.

Durante a conversão cast, o valor de float é truncado, o que significa que o valor depois do decimal é ignorado completamente.

Ao converter usando Convert.ToInt32(), o valor de float literal é corretamente arredondado para 2.
Se alterássemos o valor literal para 1.499m, ele seria arredondado para baixo para 1.

*/

int value = (int)1.5m; //casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); //converting rounds up
Console.WriteLine(value2);