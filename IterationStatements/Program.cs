namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintRange()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        public static void ByThree()
        {
            for (int t = 3; t <= 999; t += 3)
            {
                Console.WriteLine(t);
            }
        }

        //Write a method to accept two integers as parameters and check whether they are equal or not

        public static bool IsEqual(int a, int b)
        {
            var check = (a == b) ? true : false;
            return check;
        }

        //Write a method to check whether a given number is even or odd

        public static void EvenOdd()
        {
            Console.WriteLine("Enter a number to check if it's even or odd:");
            var numberToCheck = int.Parse(Console.ReadLine());

            if (numberToCheck % 2 == 0)
            {
                Console.WriteLine($"{numberToCheck} is even");
            }
            else
            {
                Console.WriteLine($"{numberToCheck} is odd");
            }
        }

        //Write a method to check whether a given number is positive or negative

        public static void IsPos()
        {
            Console.WriteLine("Enter a number to determine if it is positive or negative:");
            var input = int.Parse(Console.ReadLine());

            if (input > 0)
            {
                Console.WriteLine($"{input} is positive");
            }
            else
            {
                Console.WriteLine($"{input} is negative");
            }

        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void CanVote()
        {
            Console.WriteLine("Enter your age:");
            var age = int.Parse(Console.ReadLine());
            if (age > 18)
            {
                Console.WriteLine("You are old enough to vote");
            }
            else
            {
                Console.WriteLine("You are not old enough to vote");
            }
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void Range()
        {
            Console.WriteLine("Enter a number");
            var input = int.Parse(Console.ReadLine());
            if (input >= -10 && input <= 10)
            {
                Console.WriteLine($"{input} is in the range of -10 to 10");
            }
            else
            {
                Console.WriteLine($"{input} is not in the range of -10 to 10");
            }

        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void Table()
        {
            Console.WriteLine("Enter a number:");
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                int result = input * i;
                Console.WriteLine($"{input} * {i} = {result}");
            }

        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            PrintRange();
            ByThree();
            Console.WriteLine(IsEqual(5, 6));
            EvenOdd();
            IsPos();
            CanVote();
            Range();
            Table();
        }

    }
}