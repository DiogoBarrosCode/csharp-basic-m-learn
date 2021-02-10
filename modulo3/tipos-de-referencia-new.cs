/*

Uma variável de tipo de referência armazenará seus valores em uma região de memória separada chamada de heap.
O heap é uma área de memória compartilhada entre muitos aplicativos em execução no sistema operacional ao mesmo tempo.

A primeira linha de código reserva um endereço na memória no heap. 
A palavra-chave new informa ao runtime do .NET para criar uma instância da matriz int e, em seguida, coordena-se com
o sistema operacional para armazená-la na memória. O runtime do .NET cumpre e retorna um endereço de memória da nova matriz int.
Finalmente, o endereço de memória é armazenado nos dados de variável.


*/

int[] data;
data = new int[3];