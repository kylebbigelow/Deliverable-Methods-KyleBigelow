using System;

namespace Deliverable_Methods_KyleBigelow
{
    class AppDomainUnloadedException
    {
        static void Main(string[] args)
        {
            int Number1 = 0;
            int Number2 = 0;
            int result;
            char input = 'A';

            Console.WriteLine("Kyle Brandon Bigelow");

            Console.WriteLine("Please enter your first number");
            Number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your second number");
            Number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Which operation would you like to perform?");

            Console.WriteLine("Options");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("Please enter the number of the operation you wish to perform");

            input = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("You must enter a valid option");
            
            

            switch (input)
            {

                case '1':
                    result = Number1 + Number2;
                    Console.WriteLine("The sum of " +" "+ Number1 +" "+ "and" +" "+ Number2 +" "+ "is:");
                    Console.WriteLine(result);
                    break;

                case '2':
                    result = Number1 - Number2;
                    Console.WriteLine("The difference of " + " " + Number1 + " " + "and" + " " + Number2 + " " + "is:");
                    Console.WriteLine(result);
                    break;

                case '3':
                    result = Number1 * Number2;
                    Console.WriteLine("The multiplication of " + " " + Number1 + " " + "and" + " " + Number2 + " " + "is:");
                    Console.WriteLine(result);
                    break;

                case '4':
                    {
                        try
                        {
                            result = Number1 / Number2;
                            Console.WriteLine("The division of " + " " + Number1 + " " + "by" + " " + Number2 + " " + "is:");
                            Console.WriteLine(result);
                        }
                        catch (DivideByZeroException)
                        {
                            Console.WriteLine("Cannot divide by 0");
                        }
                        break;
                    }
                    

            }
            
        }
    }
}
