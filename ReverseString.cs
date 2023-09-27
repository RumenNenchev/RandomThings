using System;
using System.Linq;

namespace da_si_testwam
{
    internal class Program
    {


        static void Main(string[] args)
        {
            // a b c d e --> e d c b a
            string[] text = Console.ReadLine()
                .Split()
                .ToArray();     
            
            for (int i = 0; i < text.Length / 2; i++) 
            {
                string firstElement = text[i];
                string last = text[text.Length - 1 - i];
                
                text[i] = last;
                text[text.Length - 1 - i] = firstElement;
            }
            Console.WriteLine(string.Join(" ", text));
            Console.ReadKey();
        }
        
    }

}