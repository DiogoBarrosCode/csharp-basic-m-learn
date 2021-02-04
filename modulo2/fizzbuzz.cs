/* Desafio do FizzBuzz */

string fizz = "Fizz";
string buzz = "Buzz";
string fizzBuzz = "FizzBuzz";


for (int i = 1; i <= 100; i++){
    
    if ((i % 3 == 0) && (i % 5 == 0)){
        Console.WriteLine($"{i} - {fizzBuzz}");
    }
    else if (i % 3 == 0){
       Console.WriteLine($"{i} - {fizz}");
    }
    else if (i % 5 == 0){
        Console.WriteLine($"{i} - {buzz}");
    }
    else{
        Console.WriteLine(i);
    }
   
}

/* 
1.  Valores de saída de 1 a 100, um número por linha.
2.  Quando o valor atual é divisível por 3, imprima o termo Fizz ao lado do número.
3.  Quando o valor atual é divisível por 5, imprima o termo Buzz ao lado do número.
4.  Quando o valor atual é divisível tanto por 3 quanto por 5, imprima o termo FizzBuzz ao lado do número.
*/