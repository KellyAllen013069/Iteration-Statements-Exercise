namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintConsecutiveNumbers()
        {
            for (int i = 1000; i > -1001; i--)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void PrintNumbersByThree()
        {
            for (int i = 3; i < 1000; i+=3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool IsEqual(int first, int last)
        {
            return first == last ? true : false;
        }
        
        //Write a method to check whether a given number is even or odd
        public static bool IsEven(int numberToCheck)
        {
            return numberToCheck % 2 == 0 ? true : false;
        }
        
        //Write a method to check whether a given number is positive or negative
        public static bool IsPositive(int numberToCheck)
        {
            return numberToCheck >= 0 ? true : false;
        }
        
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void CanVote()
        {
            Console.WriteLine("Please enter your age:");
            
            int age;
            
            bool isValid = int.TryParse(Console.ReadLine(), out age);
            if (isValid)
            {
                string voteEligibility = (age >= 18) ? "can" : "cannot";
                Console.WriteLine($"You {voteEligibility} vote.");
                return;
            }
            
            Console.WriteLine("Invalid input.");
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void InRange()
        {
            Console.WriteLine("Please enter an integer: ");
            var input = int.Parse(Console.ReadLine());
            var output = input >= -10 && input <= 10 ? "in the range" : "not in the range";
            Console.WriteLine($"Your number is {output} of -10 to 10");
        }
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultiplicationTable()
        {
            Console.WriteLine("Please enter an integer: ");
            var input = int.Parse(Console.ReadLine());
            for (int i=1;i<=12;i++)
            {
                Console.WriteLine(i * input);
            }
            
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            PrintConsecutiveNumbers();
            PrintNumbersByThree();
            
            Console.WriteLine("Enter the first integer");
            var firstInteger = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second integer");
            var secondInteger = int.Parse(Console.ReadLine());
            var result = IsEqual(firstInteger, secondInteger) ? "equal" : "not equal"; 
            Console.WriteLine($"{firstInteger} and {secondInteger} are {result}");
            
            Console.WriteLine("Please enter an integer");
            var input = int.Parse(Console.ReadLine());
            var isEvenResult = IsEven(input) ? "even" : "odd";
            Console.WriteLine($"The number you entered is {isEvenResult}");
            
            Console.WriteLine("Please enter a positive or negative integer");
            input = int.Parse(Console.ReadLine());
            var isPositiveResult = IsPositive(input) ? "positive" : "negative";
            Console.WriteLine($"The number you entered is {isPositiveResult}");
            
            CanVote();
            InRange();
            MultiplicationTable();
            
        }
    }
}

