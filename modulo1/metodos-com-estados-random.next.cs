/*

A Biblioteca de Classes do .NET é uma coleção de milhares de classes que contém dezenas de milhares de métodos.
Em muitos casos, essas classes e métodos permitem que você crie um tipo específico de aplicativo.

A Biblioteca de Classes do .NET nos fornece uma infinidade de funcionalidades que podemos usar simplesmente
referenciando as classes e os métodos de que precisamos.

*/



Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);


/*

Os métodos com estado (instância) controlam seu estado em campos, que são variáveis definidas na classe.
Cada nova instância da classe tem sua própria cópia desses campos nos quais o estado é armazenado.

Ao chamar um método com estado, é necessário criar uma instância da classe e acessar o método no objeto.
Uma instância de uma classe é chamada de um objeto. Para criar uma instância de uma classe, use o operador new.


I. A primeira linha de código cria uma instância da classe System.Random
na Biblioteca de Classes do .NET e armazena a referência ao novo objeto em uma variável denominada dice.

II. A segunda linha de código chama o método Next() do objeto dice que passa dois parâmetros:
o valor mínimo e o máximo do número aleatório. O método Next() retorna o valor, que salvamos em uma variável chamada roll.

III. A terceira linha de código chama o método WriteLine() para imprimir o valor de roll no console.

*/