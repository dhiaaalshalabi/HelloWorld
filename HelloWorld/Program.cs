class Program
{
    static void Main(string[] args)
    {
        var numbers = new[] { 3, 7, 9, 2, 14, 6 };
        
        // Length()
        Console.WriteLine("Length: "+numbers.Length);
        
        // IndexOf()
        var index = Array.IndexOf(numbers, 9);
        Console.WriteLine("Index of 9: "+index);
        
        // Clear()
        Array.Clear(numbers,0,2);
        
        Console.WriteLine("Effect of Clear()");
        foreach (var number in numbers)
            Console.WriteLine(number);
        
        // Copy()
        int[] another = new int[3];
        Array.Copy(numbers,another,3);
        Console.WriteLine("Effect of Copy()");
        foreach (var i in another)
            Console.WriteLine(i);
        
        // Sort()
        Array.Sort(numbers);
        Console.WriteLine("Effect of Sort()");
        foreach (var i in numbers)
            Console.WriteLine(i);
        
        // Reverse()
        Array.Reverse(numbers);
        Console.WriteLine("Effect of Reverse()");
        foreach (var number in numbers)
            Console.WriteLine(number);
    }
}
