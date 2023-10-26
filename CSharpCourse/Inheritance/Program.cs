

internal class Program 
{
	static void Main(string[] args)
	{
		Person[] persons = new Person[]
		{
			new Customer{ FirstName = "Yusuf" },
			new Student{ FirstName = "Bahadir" },
			new Person{ FirstName = "Berat" }
		};

		foreach (Person person in persons) 
		{
			Console.WriteLine(person.FirstName);
		}
	}

	class Person 
	{
		public int Id { get; set; }
		public string FirstName { get; set; } = string.Empty;
		public string LastName { get; set; } = string.Empty;
	}

	class Person2 {}

	class	Customer : Person //only one inherit object but interface different
	{
		public string City { get; set; } = string.Empty;
	}

	class Student : Person
	{
		public string Deparmant { get; set; } = string.Empty;
	}
}
