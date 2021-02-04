/* Percorrer cada elemento de uma matriz */

string[] names = {"Alex", "Eddie", "David", "Michael"};

for (int i = names.Length - 1; i >= 0; i--){
    Console.WriteLine(names[i]);
}

/*
Nesse caso, iteramos por meio da matriz para trás, algo que
não seria possível fazer com a instrução foreach. 
Usamos a propriedade Length para inicializar a variável de
iterador e subtraímos uma de i com cada iteração. Dentro do
bloco de código, indexamos na matriz usando a variável de iteração.
*/