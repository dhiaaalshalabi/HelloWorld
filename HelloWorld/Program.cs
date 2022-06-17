
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Dhiaa";
            string lastName = "Al-Shalabi";
            String fullName = "Dhiaa Al-Shalabi";

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[2] { firstName, lastName };
            var formattedNames = string.Join(", ", names);

            Console.WriteLine(formattedNames);
        }
    }
}
