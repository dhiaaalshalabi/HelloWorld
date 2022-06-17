
using HelloWorld.Math;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "Jhon";
            john.LastName = "Smith";
            john.Print();
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
        }
    }
}
