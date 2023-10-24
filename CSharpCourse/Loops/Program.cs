
internal class Program
{
    private static void Main(string[] args)
    {
        //ForLoop();
        //WhileLoop();
        //DoWhileLoop();
        //ForEachLoop();

        if (IsPrimeNumber(7))
            Console.WriteLine("This is a prime number!");
        else
            Console.WriteLine("This is not a prime number!");
    }

    private static bool IsPrimeNumber(int number)
    {
        for (int i = 2; i <= number / 2; i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }

    private static void ForEachLoop()
    {
        string[] students = new string[3] { "Engin", "Derin", "Salih" };
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }

    private static void DoWhileLoop()
    {
        int number = 100;
        do
        {
            Console.WriteLine(number);
            number--;
        } while (number >= 0);
    }

    private static void WhileLoop()
    {
        int number = 100;
        while (number >= 0)
        {
            Console.WriteLine(number);
            number--;
        }
    }

    private static void ForLoop()
    {
        for (int i = 100; i >= 0; i--)
        {
            Console.WriteLine(i);
        }
    }
}