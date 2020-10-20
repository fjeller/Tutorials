using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithObjects
{
	public class Address : INameable, ISomethingDoable
	{

		public string Name { get; set; }

		public string Street { get; set; }

		public string ZipCode { get; set; }

		public string City { get; set; }

		public override string ToString()
		{
			return GetOutput();
		}

		public virtual string GetOutput()
		{
			return $"{Name}\r\n{Street}\r\n\r\n{ZipCode} {City}";
		}

		public string LastName { get; set; }
		public string FirstName { get; set; }

		public string DoSomething()
		{
			return "DoSomething aus Address - (INameable implementierung)";
		}

		string ISomethingDoable.DoSomething()
		{
			return "ISomethingDoable.DoSomething()";
		}
	}
}
