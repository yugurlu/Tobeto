using System;
namespace GenericsIntro
{
	public class MyList<T>
	{
		T[] items;

		//constructor
		public MyList()
		{
			items = new T[0];
		}

		public void Add(T item)
		{
            T[] temp = (T[])items.Clone();
            items = new T[items.Length + 1];
			for (int i = 0; i < temp.Length; i++)
			{
				items[i] = temp[i];
			}
			items[items.Length - 1] = item;
		}
	}
}

