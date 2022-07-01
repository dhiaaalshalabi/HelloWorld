class Program
{
    static void Main(string[] args)
    {
        var dateTime = new DateTime(2022, 7, 1);
        var now = DateTime.Now;
        var today = DateTime.Today;
        
        Console.WriteLine("Hour: "+now.Hour);
        Console.WriteLine("Minute: "+now.Minute);
        
        // DateTime are mutable
        var tomrrow = now.AddDays(1);
        var yesterday = now.AddDays(-1);
        
        Console.WriteLine(tomrrow);
        Console.WriteLine(yesterday);
        
        Console.WriteLine(now.ToLongDateString());
        Console.WriteLine(now.ToShortDateString());
        Console.WriteLine(now.ToLongTimeString());
        Console.WriteLine(now.ToShortTimeString());
        Console.WriteLine(now.ToString("yyyy-MM-dd"));
    }
}
