
namespace HelloWorld
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisterAirMail = 2,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);
            Console.WriteLine(method.ToString());

            var methodName = "Express";
            var shippingMethod = Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod.ToString());
        }
    }
}
