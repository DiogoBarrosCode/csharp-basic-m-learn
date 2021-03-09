/*

Ao trabalhar com os dados numéricos, convém formatar o número para facilitar a leitura incluindo vírgulas 
para delinear milhares, milhões, bilhões e assim por diante.

O especificador de formato numérico N fará isso.


*/

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");


/*

Por padrão, o especificador de formato numérico N exibe apenas dois dígitos após o ponto decimal.

Se desejar mostrar mais precisão, adicione um número após o especificador N.

*/

Console.WriteLine("");

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N4} units");