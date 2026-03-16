class Program
{
    static void Main()
    {
        int n, first = 0, second = 1, next;

        Console.Write("Enter the number of series: ");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine("Fibonacci Series is:");

        for (int i = 1; i <= n; i++)
        {
            Console.Write(first + " ");

            next = first + second;
            first = second;
            second = next;
        }
    }
}
