class Program
{
    static void Main(string[] args)
    {
        // Task 1
        string name = "John Doe";
        int age = 25;
        bool isAdmin = true;

        Console.WriteLine(name);
        Console.WriteLine(age);
        Console.WriteLine(isAdmin);

        // Task 2
        int input = int.Parse(Console.ReadLine());

        if (input % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }

        // Task 3
        for (int i = 1; i < 11; i++)
        {
            Console.WriteLine(i);
        }

        // Task 4
        int[] values = { 2, 4, 6, 8, 10};
        int sum = 0;
        foreach (var value in values)
        {
            Console.WriteLine(value);
            sum += value;
        }
        Console.WriteLine($"Sum of array: {sum}");

        // Task 5
        Console.WriteLine(Greet("Alice"));
    }
    static string Greet(string name)
    {
        return $"Hello, {name}!";
    }
}