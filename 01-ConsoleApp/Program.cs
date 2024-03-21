// this app represents the udemy course from Jannick Leismann https://www.udemy.com/course/csharp-grundlagenkurs-fuer-anfaenger
namespace ConsoleApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // i call all my lessions as private methods from here
            Thirteen();
        }

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

        private static void Eighteen()
        {
            // user input
            Console.WriteLine("Biite gib deinen Namen ein:");
            string name = Console.ReadLine();

            Console.WriteLine("Dein Name ist " + name);

        }

        private static void Nineteen()
        {
            // user input
            Console.WriteLine("Biite gib deinen Namen ein:");
            string name = Console.ReadLine();

            Console.WriteLine("Dein Name ist " + name);

        }
    }
}