/*

O código utiliza o Remove() para remover caracteres em locais específicos de uma cadeia de caracteres. Nesse caso da 
posição 5 até a 20.

O método Remove() funciona de forma semelhante ao método Substring(). Defina uma posição inicial e o comprimento para 
remover esses caracteres da cadeia de caracteres.


*/


string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);



/*

Saída:

123455000  3  

*/