using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithObjects
{
	class Program
	{

		private static void ExchangeValues( ref int a, ref int b )
		{
			(b, a) = (a, b);
			//int c = a;
			//a = b;
			//b = c;
		}

		private static void DoSomethingElse( ref string name )
		{
			name = "Moritz";
		}

		private static void DoSomething( Address address )
		{
			address.Name = "Moritz";
			//address = new Address
			//{
			//	Name = "Moritz",
			//	City = "Karlsruhe",
			//	Street = "Frühlingstraße 8",
			//	ZipCode = "76131"
			//};
		}

		private static (string name, string vorname) GetName()
		{
			return ("eller", "frank");
		}

		private static void PutOut(Address address)
		{
			Console.WriteLine(address);
		}

		static void Main( string[] args )
		{
			//int a = 5;
			//int b = 6;

			//ExchangeValues( ref a, ref b );

			//Console.WriteLine( a );
			//Console.WriteLine( b );

			//Address address = new Address
			//{
			//	Name = "Frank",
			//	City = "Karlsruhe", 
			//	Street = "Frühlingstraße 8", 
			//	ZipCode = "76131"
			//};

			AddressWithCountry address = new AddressWithCountry
			{
				Name = "Frank",
				City = "Karlsruhe",
				Street = "Frühlingstraße 8",
				ZipCode = "76131",
				Country = "Germany"
			};

			Console.WriteLine(address.DoSomething());

			Console.WriteLine(((ISomethingDoable) address).DoSomething());

			Decimal.TryParse("3434", NumberStyles.AllowCurrencySymbol | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent, out decimal d);



			////string name = "Frank";

			////DoSomethingElse(ref name);
			//DoSomething( address );

			//PutOut(address);


			//			(string name, string vorname) test = GetName();




		}
	}
}
