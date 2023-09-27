using System;


namespace da_si_testwam
{
    internal class Program
    {


        static void Main(string[] args)
        {

            const string rock = "Rock";
            const string paper = "Paper";
            const string scissors = "Scissors";

            Random random = new Random();
            int computerRandom = random.Next(1, 4);
            string computer= "";

            Console.WriteLine("Choose [r]ock, [p]aper, [s]cissors");

            string player = Console.ReadLine();

            if (player == "r" || player == "rock")
            {
                player = rock;
            }
            else if (player == "p" || player == "paper")
            {
                player = paper;


            }

            else if (player == "s" || player == "scissors")
            {
                player = scissors;
            }

            switch (computerRandom)

            {
                case 1:
                    computer = rock;
                    break;
                case 2:
                    computer = paper;
                    break;
                case 3:
                    computer = scissors;
                    break;

            }

            Console.WriteLine($"Computer chooses {computer}");

            if ((player == rock && computer == scissors) ||
                (player == scissors && computer == paper) ||
                (player == paper && computer == rock)
                )
            {
                Console.WriteLine("You win.");

            }
            else if ((player == scissors && computer == scissors) ||
                (player == paper && computer == paper) ||
                (player == rock && computer == rock))
            {
                Console.WriteLine("Draw!");
            }
         else
            {
                Console.WriteLine("You lose.");
            }    
            Console.ReadKey();
        }
        
    }

}