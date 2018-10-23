using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLesson
{
	public class Person
	{
		public string Name { get; set; }
		public DateTime Birthday { get; set; }
	}

	public class Employee : Person
	{
		public int Id { get; set; }
		public string DivisionName { get; set; }
	}

	public class Student : Person
	{
		public int Grade { get; set; }
		public int ClassNumber { get; set; }
	}
}
