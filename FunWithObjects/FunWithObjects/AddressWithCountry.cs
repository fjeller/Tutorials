using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithObjects
{
	public class AddressWithCountry : Address 
	{

		public string Country { get; set; }

		public override string GetOutput()
		{
			return $"{Name}\r\n{Street}\r\n\r\n{ZipCode} {City}\r\n{Country}";
		}

	}
}
