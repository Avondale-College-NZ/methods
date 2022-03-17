using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This programs makes use of methods to perform basic arithmetic operations\n\n");
            char choice = 'y';
            int option, num1, num2;

            Console.Write("Enter a number: ");
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("\nPlease enter a valid number only: ");
            }
            Console.Write("Enter another number: ");
            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.Write("\nPlease enter a valid number only: ");
            }

            do
            { 
                Console.WriteLine("\n1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Remainder");
                Console.Write("\nNow, enter the choice of your arithmetic operation:  ");

                while(!int.TryParse(Console.ReadLine(), out option) || option <=0 || option >=6)
                {
                    Console.Write("\nPlease enter a valid option number only: ");
                }


                switch (option)
                {                                        
                    case 1:
                        Console.WriteLine("The sum of the two numbers you entered is " + addition(num1, num2));
                        break;

                    case 2:
                        Console.WriteLine("The difference of the two numbers you entered is " + subtraction(num1, num2));
                        break;

                    case 3:
                        Console.WriteLine("The product of the two numbers you entered is " + multiplication(num1, num2));
                        break;
                    case 4:
                        Console.WriteLine("The quotient of the two numbers you entered is " + division(num1, num2));
                        break;

                    default:
                        Console.WriteLine("The remainder of the two number you entered is " + remainder(num1, num2));
                        break;
                }

                Console.Write("\nTo perform another operation, press y/Y or any other key to end: ");
                choice = char.Parse(Console.ReadLine());

            } while (choice == 'y');

            Console.WriteLine("\nThanks for using this program...Good Bye\nPress Enter to Exit");
            Console.ReadKey();
        }

        

        public static int addition(int x, int y)
        {
            return x + y;
        }
        public static int subtraction(int x, int y)
        {
            return x - y;
        }
        public static int multiplication(int x, int y)
        {
            return x * y;
        }
        public static int division(int x, int y)
        {
            return x / y;
        }
        public static int remainder(int x, int y)
        {
            return x % y; 
        }
    }
}
