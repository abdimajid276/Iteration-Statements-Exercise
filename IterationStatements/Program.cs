namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through -1000

        public static void PrintNumbers1000()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        
        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        public static void ByThrees()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not

        public static void NUmbersSame(int numOne, int numTwo)
        {
            if (1 == 2)
            {
                Console.WriteLine($"{numOne} and {numTwo} are the same!");
            }
            else
            {
                Console.WriteLine($"{numOne} and {numTwo} are not the same!");
            }
    }
        
        //Write a method to check whether a given number is even or odd

        public static void OddEven(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"Even");
            }
            else
            {
                Console.WriteLine($"Odd");
            }
        }
        
        //Write a method to check whether a given number is positive or negative

        public static void PosNeg(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"Positive");
            }
            else if (number == 0)
            {
                Console.WriteLine("Zero");
            }
            else
            {
                Console.WriteLine($"Negative");
            }
        }
        
        
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        public static void CanDeter()
        {
            Console.WriteLine("Please enter your age:");
            var canParse = int.TryParse(Console.ReadLine(), out int userAge);

            while (canParse == false)
            {
               Console.WriteLine("please enter a valid age:");
               canParse = int.TryParse(Console.ReadLine(), out userAge); 
            }

            if (userAge >= 18)
            {
                Console.WriteLine(($"Congrats, {userAge} is old enough to vote!"));
            }
            else
            {
                Console.WriteLine($"Sorry, {userAge} is not old enough to vote!");
            }
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static void TenNeg()
        {
            Console.WriteLine("Please give me a number:");
            var canParse = int.TryParse(Console.ReadLine(), out int userNumber);

            while (!canParse)
            {
                Console.WriteLine("Please enter a valid number:");
                canParse = int.TryParse(Console.ReadLine(), out userNumber);
            }

            if (userNumber <= 10 && userNumber >= -10) 
            {
                Console.WriteLine($"{userNumber} is in the ten range!");
            }
            else
            {
                Console.WriteLine($"{userNumber} is not in the ten range!");
            }
        }
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void MultiTab(int number)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} * {number} = {i * number} ");
            }
        }


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            //PrintNumbers1000();
            //ByThrees();
            //NUmbersSame(numOne:1 , numTwo:2);
            //OddEven(number:2);
            //PosNeg(number:2);
            //CanDeter();
            //TenNeg();
            //MultiTab(number:10);
        }
    }
}
