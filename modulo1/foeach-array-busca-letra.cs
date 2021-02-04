/** Vamos escrever um novo código para gerar a ID, em que a ID começa com a letra "B". **/

string[] idFalse = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

foreach (string idLoad in idFalse)
{
    if (idLoad.StartsWith("B")){
        Console.WriteLine(idLoad);
    }
}