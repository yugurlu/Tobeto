

internal class Program
{
    private static void Main(string[] args)
    {
        int number1 = 20;
        int number2 = 100;

        Add();
        Console.WriteLine(Add2(2));
        Console.WriteLine(Add3(ref number1, number2));
        Console.WriteLine(number1);
        Console.WriteLine(Multiply(3, 2));
        Console.WriteLine(Multiply(3, 2, 1));
        Console.WriteLine(Add4(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 31));
    }

    static void Add()
    {
        Console.WriteLine("Added!");
    }

    static int Add2(int number1 = 20, int number2 = 30)
    {
        return number1 + number2;
    }

    static int Add3(ref int number1, int number2)
    {
        number1 = 10;
        return number1 + number2;
    }

    static int Add4(params int[] numbers)
    {
        return numbers.Sum();
    }

    static int Multiply(int number1, int number2)
    {
        return number1 * number2;
    }

    static int Multiply(int number1, int number2, int number3)
    {
        return number1 * number2 * number3;
    }
}