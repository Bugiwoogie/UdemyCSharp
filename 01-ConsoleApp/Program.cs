// this app represents the udemy course from Jannick Leismann https://www.udemy.com/course/csharp-grundlagenkurs-fuer-anfaenger
namespace ConsoleApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // i call all my lessions as private methods from here
            Nineteen();
        }

        // 2. Variables

        // i had the cool idea to split everthing into private methods for a better overview
        private static void Ten()
        {
            // find the right datatype for the result variable
            float myFloat = 100.5f;
            int myInt = 200;

            float result = myFloat + myInt;
            Console.WriteLine(value: result);
        }

        private static void Eleven()
        {
            // naming conventions ( snakeCase )
            string name = "Ravi";
            string lastName = "Yolomann";

            string entireName = name + " " + lastName;
            Console.WriteLine(entireName);
        }

        private static void Twelve()
        {
            // boolean
            bool isAdult = true;
            bool isCool = false;
        }

        private static void Thirteen()
        {
            // char
            char firstLetter = 'R';
            char secondLetter = 'a';
            char thirdLetter = 'v';
            char lastLetter = 'i';

            Console.WriteLine(firstLetter + secondLetter + thirdLetter + lastLetter);
        }

        // this variable is ceated in within the class because now you can use it in more than one Method
        static string username = "Scope Ravi";

        private static void Fifteen()
        {
            username = "Mhpf";
            // scope
            Console.WriteLine(username);
        }

        // 3. User input

        private static void Eighteen()
        {
            // user input
            Console.WriteLine("Biite gib deinen Namen ein:");
            string name = Console.ReadLine();

            Console.WriteLine("Dein Name ist " + name);

        }

        private static void Nineteen()
        {
            // DateTime
            Console.WriteLine("Wie alt bist du? ");
            string age = Console.ReadLine();

            int birthYear = DateTime.Now.Year - int.Parse(age);

            Console.WriteLine("Dein Geburtsjahr ist: " + birthYear + "... oder " + (birthYear - 1));
        }

        private static void Twenty()
        {
            // debugging
            // Mhpf the teacher told me something about breakpoints ( in german: Brechpunkt :) )
        }

        // 4. Arrays

        private static void TwentyOne()
        {
            /* intoduction to arrays
            in CSharp arrays have a fixed size, so they are not used so often.
            Instead they are using Collections or Lists to have something more dynamically.
            Also arrays have a fixed Datatype, you cannot mix the values you save in arrays
            */ 
        }

        private static void TwentyThree()
        {
            // declaration and initialization
            int[] numbers = new int[3]
            {
                1,
                2,
                3
            };
        }

        private static void TwentyFive()
        {
            // sorting
            int[] numbers = new int[3]
            {
                1,
                69,
                3
            };
            Array.Sort(numbers); // asc
        }

        private static void TwentySix()
        {
            // other datatypes
            string[] words = new string[3]
            {
                "omg",
                "boring",
                "mhpf"
            };
        }

        private static void TwentyEight()
        {
            // array index and loops
            int[] numbers = new int[] { 50, 200, 75 };
            int result = 0;

            // foreach
            foreach (int value in numbers)
            {
                result += value;
            }
            Console.WriteLine(result);


            // for loop
            result = 0;
            for (int index = 0; index < numbers.Length; index++)
            {
                // Console.WriteLine(numbers[index]);
                result = result + numbers[index];
            }

            // while loop
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }

            // do while
            do { /*code gets executed */ } while ( true); // after this there is a check
        }

        // 6. If Statements
        private static void ThirtyFive()
        {
            // introduction
            int number = 10;
            if (number > 10)
            {
                // execute some code
            }
        }

        private static void ThirtySix()
        {
            // operators
            /*
             * >
             * >=
             * <
             * <=
             * == boring
             * != 
             * ||
             */

            // i do not coment this -.-
        }

        private static void ThirtySeven()
        {
            // multiple conditions

            // use &&

        }

        // ThirtyEight is if else blah
        // You can also use if then else like this:
        // condition ? then do this code : else to this code

        // ThirtyNine = else if

        // FourtyTwo here the teacher checks two conditions
        int justForPushingToGithub = 0;
    }
}