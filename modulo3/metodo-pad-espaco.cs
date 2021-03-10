/*

Espaços em branco.

O método PadLeft() adicionará espaços em branco ao lado esquerdo da cadeia de caracteres 
para que o número total de caracteres seja igual ao argumento enviado por você. Para adicionar
 espaço ou caracteres ao lado direito da cadeia de caracteres, use o método PadRight().

Nesse caso, queremos que o comprimento total da cadeia de caracteres seja 12 caracteres.

*/

string input = "Pad this";
Console.WriteLine(input.PadLeft(12));
Console.WriteLine(input.PadRight(12));


Console,WriteLine("");

/*

Método sobrecarregado.

No C#, um método sobrecarregado é outra versão de um método com argumentos diferentes ou adicionais
que modificam a funcionalidade do método ligeiramente.

Essa é uma versão sobrecarregada dos métodos PadLeft() e PadRight(), preenchendo o espaço extra com o caractere de traço.

*/

string input = "Pad this";
Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));