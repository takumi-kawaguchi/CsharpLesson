using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherNamespace
{
	public class Product
	{
		public int Code { get; private set; }
		public string Name { get; private set; }
		public int Price { get; private set; }

		public Product(int code, string name, int price)
		{
			this.Code = code;
			this.Name = name;
			this.Price = price;
		}

		public int GetTax()
		{
			return (int)(this.Price * 0.08);
		}

		public int GetPriceIncludedTax()
		{
			return this.Price + GetTax();
		}
	}

	public class MyClass
	{
		public MyClass(int X, int Y)
		{
			this.X = X;
			this.Y = Y;
		}

		public int X { get; set; }
		public int Y { get; set; }
	}

	public struct MyStruct
	{
		public MyStruct(int X, int Y) : this()
		{
			this.X = X;
			this.Y = Y;
		}

		public int X { get; set; }
		public int Y { get; set; }
	}

	public class MyPoint
	{
		public int X { get; set; }
		public int Y { get; set; }

		public MyPoint(int x, int y)
		{
			this.X = x;
			this.Y = y;
		}
	}
}
