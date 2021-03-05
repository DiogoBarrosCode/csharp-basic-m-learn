/*

O desafio a seguir transforma uma cadeia de caracteres em uma matriz utilizando Split()

Depois percorre o array com foreach com a condição que será exibido na saída do console
apenas os items da matriz que se iniciem com a letra B. Para isso utilizamos StartsWith().

*/


string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orderStreamArray = orderStream.Split(',');
foreach(string items in orderStreamArray){
    if(items.StartsWith("B"))
    {
        Console.WriteLine($"{items}");
    }
}