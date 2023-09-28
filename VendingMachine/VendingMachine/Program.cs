using System;

class VendingMachine
{
    static void Main(string[] args)
    {
        double balance = 0.0;

        while (true)
        {
            Console.WriteLine("Welcome to the Vending Machine!");
            Console.WriteLine("1. Add money");
            Console.WriteLine("2. Buy a product");
            Console.WriteLine("3. Exit");
            Console.Write("Please select an option: ");
            //TODO ADD 4. OPTION SHOW MONEY

            string choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter the amount of money to add: ");
                    if (double.TryParse(Console.ReadLine(), out double amountToAdd))
                    {
                        balance += amountToAdd;
                        Console.WriteLine($"Your balance: {balance:C2}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid amount.");
                    }
                    break;

                case "2":
                    Console.WriteLine("Available Products:");
                    Console.WriteLine("1. Nuts - $2.00");
                    Console.WriteLine("2. Water - $0.70");
                    Console.WriteLine("3. Crisps - $1.50");
                    Console.WriteLine("4. Soda - $0.80");
                    Console.WriteLine("5. Coke - $1.00");
                    Console.Write("Enter the number of the product you want to buy: ");
                    //TODO Add new MENU WITH NEW PRODUCTS

                    if (int.TryParse(Console.ReadLine(), out int productChoice) && productChoice >= 1 && productChoice <= 5)
                    {
                        double productPrice = 0.0;

                        switch (productChoice)
                        {
                            case 1:
                                productPrice = 2.0;
                                break;
                            case 2:
                                productPrice = 0.7;
                                break;
                            case 3:
                                productPrice = 1.5;
                                break;
                            case 4:
                                productPrice = 0.8;
                                break;
                            case 5:
                                productPrice = 1.0;
                                break;
                                //TODO ADD MORE PRODUCTS
                        }

                        if (balance >= productPrice)
                        {
                            balance -= productPrice;
                            Console.WriteLine("Enjoy your product!");
                        }
                        else
                        {
                            Console.WriteLine("Insufficient balance. Please add more money.");
                        }

                        Console.WriteLine($"Your balance: {balance:C2}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid product choice. Please select a valid product.");
                    }
                    break;

                case "3":
                    Console.WriteLine($"Thank you for using the Vending Machine! Your remaining balance: {balance:C2}");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }
}
