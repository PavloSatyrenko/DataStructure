using DataStructureLibrary;

namespace DataStructure
{
	internal class Program
	{
		static void Main(string[] args)
		{
			MyDataStructure myDataStructure = new MyDataStructure();
			myDataStructure.Add(5);
			myDataStructure.Add(6);
			myDataStructure.Add(7);
			myDataStructure.Add(3);
			myDataStructure.Add(9);
			myDataStructure.Remove(7);
			Console.WriteLine(myDataStructure.Root.Value);
			Console.WriteLine(myDataStructure.Root.Next.Value);
			Console.WriteLine(myDataStructure.Root.Next.Next.Value);
			Console.WriteLine(myDataStructure.Root.Next.Next.Next.Value);
			Console.WriteLine("---------");

			MyDataStructure myDataStructure2 = new MyDataStructure();
			myDataStructure2.Add(5);
			myDataStructure2.Add(6);
			myDataStructure2.Add(7);
			myDataStructure2.Add(3);
			myDataStructure2.Add(9);
			myDataStructure2.Remove(7);
			Console.WriteLine(myDataStructure2.GetProductOfNumbersLessThanAverage());
			Console.WriteLine("---------");

			MyDataStructure myDataStructure3 = new MyDataStructure();
			myDataStructure3.Add(5);
			myDataStructure3.Add(6);
			myDataStructure3.Add(7);
			myDataStructure3.Add(3);
			myDataStructure3.Add(9);
			myDataStructure3.Remove(7);
			Console.WriteLine(myDataStructure3.FindFirstMultipleOfThree().Value);
			Console.WriteLine("---------");

			MyDataStructure myDataStructure4 = new MyDataStructure();
			myDataStructure4.Add(5);
			myDataStructure4.Add(6);
			myDataStructure4.Add(7);
			myDataStructure4.Add(3);
			myDataStructure4.Add(9);
			myDataStructure4.Remove(7);
			MyDataStructure newDataStructure = myDataStructure4.GetNewStructureOfMultipleOfThree();
			Console.WriteLine(newDataStructure.Root.Value);
			Console.WriteLine(newDataStructure.Root.Next.Value);
			Console.WriteLine(newDataStructure.Root.Next.Next.Value);
			Console.WriteLine("---------");

			MyDataStructure myDataStructure5 = new MyDataStructure();
			myDataStructure5.Add(5);
			myDataStructure5.Add(6);
			myDataStructure5.Add(7);
			myDataStructure5.Add(3);
			myDataStructure5.Add(9);
			myDataStructure5.RemoveBiggerThanAverage();
			Console.WriteLine(myDataStructure5.Root.Value);
			Console.WriteLine(myDataStructure5.Root.Next.Value);
			Console.WriteLine(myDataStructure5.Root.Next.Next.Value);
		}
	}
}