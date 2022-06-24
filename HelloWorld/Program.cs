class Program
{
    static void Main(string[] args)
    {
        var numbers = new List<int> { 1, 2, 3, 4 };
        numbers.Add(1);
        numbers.AddRange(new int[] { 5, 6, 7 });
        foreach (var number in numbers)
            Console.WriteLine(number);

        Console.Write("Index of 2: " + numbers.IndexOf(2));
        Console.WriteLine("Last index of 1: " + numbers.LastIndexOf(1));
        Console.WriteLine("Count items: "+numbers.Count);

        numbers.Remove(1);
        foreach (var number in numbers)
            Console.WriteLine(number);

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == 1)
                numbers.Remove(numbers[i]);
        }

        Console.WriteLine("Last effected array");
        foreach (var number in numbers)
            Console.WriteLine(number);
        
        numbers.Clear();
        Console.WriteLine("Count after clear: "+numbers.Count);
    }
}
