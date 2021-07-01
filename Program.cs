using System;

namespace elefante
{
    class Program
    {
        static void Main(string[] args)
        {
            int elefante=0;
            Console.WriteLine("+------------+");
            Console.WriteLine("|--Elefante--|");
            Console.WriteLine("+-------------+");

            Console.Write("Digite a quantidade de elefantes: ");

            do{
                elefante = Convert.ToInt32(Console.ReadLine());
                if( elefante % 2 !=0)
                {
                    Console.Write("Digite somente numeros pares: \n");
                }

            } while(elefante % 2 !=0);

            for(int i = 0 ; i < elefante; i++){
              Console.Write($"{i + 1} elefantes");

                if(i % 2  ==0)
                {  
                    Console.WriteLine(" incomodam muita gente");  
                }

                if(i % 2 != 0)
                {
                    for(int c = 0 ; c <= i; c++)
                    {
                        Console.Write(" incomodam");
                    }
                    Console.WriteLine(" muito mais");
                }  
            } 
        }
    }
}
