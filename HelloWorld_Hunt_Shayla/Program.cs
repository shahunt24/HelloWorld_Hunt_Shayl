namespace HelloWorld_Hunt_Shayla
{
    internal class Program
    {
        static void Main(string[] args) // The Main method is
        {
            Console.WriteLine("What's your first name?"); // Asks user for their first name
            string firstName = Console.ReadLine(); // Assigns the user input firstName variable
            Console.WriteLine("What is your last name?"); // Askes user for their last name
            string lastName = Console.ReadLine(); // Assigns user input lastName variable

            Console.WriteLine($"Hello, {firstName} {lastName}!"); // Prints a message that says first and last name
        }
    }
}
