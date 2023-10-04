namespace Arrays2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool equals = true;

            Console.WriteLine("Enter first array");
            int lenght = Int32.Parse(Console.ReadLine());

            int[] ArrA = new int[lenght];


            for (int i = 0; i < ArrA.Length; i++)
            {
                Console.WriteLine($"Enter elements {i}");
                ArrA[i] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter second array");

            if (lenght != Int32.Parse(Console.ReadLine()))
            {
                Console.WriteLine("Arrays have different lenghts");
            }
            else
            {
                int[] ArrB = new int[lenght];

                for (int i = 0; i < ArrB.Length; i++)
                {
                    Console.WriteLine($"Enter element {i}");
                    ArrB[i] = Int32.Parse(Console.ReadLine());
                }

                for (int i = 0; i < ArrA.Length; i++)
                {
                    if (ArrA[i] != ArrB[i])
                    {
                        Console.WriteLine("Arrays are different");
                        equals = false;
                        break;
                    }
                    

                }
                if (equals)
                {
                    Console.WriteLine("Arrays are the same");
                }
            }

        }
    }
}