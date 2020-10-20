using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithObjects
{
	public interface INameable
	{

		string LastName { get; set; }

		string FirstName { get; set; }

		string DoSomething();

	}
}
