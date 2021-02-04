using System;
using MyNewApp.Utilities;

namespace MyNewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "Microsoft Learn";
            string reversedValue = Utility.Reverse(value);
            Console.WriteLine($"Secret message: {reversedValue}");
        }
    }
}

namespace MyNewApp.Utilities
{
    class Utility
    {
        public static string Reverse(string message)
        {
            char[] letters = message.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }
    }
}

/* A instrução using é adicionada à parte superior de um arquivo de código.
Ela resolve os nomes de classe que são usados no arquivo, instruindo o
compilador a examinar a lista de namespaces para localizar todos os nomes de classe. 

using System; possibilita chamar Console.WriteLine() em vez de System.Console.WriteLine().
*/

