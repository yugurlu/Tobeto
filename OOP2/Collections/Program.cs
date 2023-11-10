
string[] names = new string[] { "Yusuf", "Engin", "Kerem", "Berat" };
Console.WriteLine(names[0]);
Console.WriteLine(names[1]);
Console.WriteLine(names[2]);
Console.WriteLine(names[3]);

//names[4] = "asd"; out of range exc

Console.WriteLine("-------------------------------------------------");

List<string> names2 = new List<string>() { "Yusuf", "Engin", "Kerem", "Berat" };
Console.WriteLine(names2[0]);
Console.WriteLine(names2[1]);
Console.WriteLine(names2[2]);
Console.WriteLine(names2[3]);

names2.Add("Bahadir");


void swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}

int a = 10;
int b = 31;

swap(ref a, ref b);

Console.WriteLine(a + " " + b);


