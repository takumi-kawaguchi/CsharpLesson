using AnotherNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLesson
{
	class Program
	{
		static void Main(string[] args)
		{
			var dorayaki = new Product(98, "どらやき", 210);
			Console.WriteLine(dorayaki.GetTax());

			var c = new MyClass(X: 10, Y: 20);
			var s = new MyStruct(X: 30, Y: 40);
			Program.PrintObject(c, s);

			Console.WriteLine("myclass: {0}, {1}", c.X, c.Y);
			Console.WriteLine("mystruct: {0}, {1}", s.X, s.Y);

			var student = new Student()
			{
				Name = "takumi",
				Birthday = DateTime.Today,
				Grade = 6,
				ClassNumber = 3
			};

			Console.WriteLine("name: {0}, birthday: {1}, grade: {2}, classnumber: {3}", student.Name, student.Birthday, student.Grade, student.ClassNumber);

			Console.ReadKey();
		}

		static void PrintObject(MyClass c, MyStruct s)
		{
			Console.WriteLine("myclass: {0}, {1}", c.X, c.Y);
			Console.WriteLine("mystruct: {0}, {1}", s.X, s.Y);

			c.X *= 2;
			c.Y *= 2;

			s.X *= 2;
			s.Y *= 2;
		}
	}
}
