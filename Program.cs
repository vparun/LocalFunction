public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Local function example");
        int a = 40, b = 20;
        int sum = Sum(a, b);
        int difference = Difference(a, b);

        Console.WriteLine($"The Sum of {a} and {b} is {sum}");
        Console.WriteLine($"The Difference of {a} and {b} is {difference}");

        int Sum(int a, int b)
        {
            return a + b;
        }

        int Difference(int a, int b)
        {
            return a - b;
        }
    }
}
