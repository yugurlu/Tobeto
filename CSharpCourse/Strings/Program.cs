
internal class Program
{
    static void Main(string[] args)
    {
        //Intro();
        string sentence = "My name is Yusuf Ugurlu";

        var result = sentence.Length;
        var result2 = sentence.Clone(); // not referance copy!

        bool result3 = sentence.EndsWith("u");
        bool result4 = sentence.StartsWith("y");

        var result5 = sentence.IndexOf("Yusuf");
        var result6 = sentence.LastIndexOf("Yusuf");
        var result7 = sentence.Insert(0, "Hello, ");
        var result8 = sentence.Substring(3);
        var result9 = sentence.ToLower();
        var result10 = sentence.ToUpper();
        var result11 = sentence.Replace(" ", "-");
        var result12 = sentence.Remove(2, 5);

        Console.WriteLine(result12);
    }

    private static void Intro()
    {
        string city = "ankara";

        foreach (var item in city)
            Console.WriteLine(item);

        string city2 = "istabul";

        Console.WriteLine(string.Format("{0} {1}", city, city2));
    }
}