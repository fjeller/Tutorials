using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateSample.WorkerWithEvent
{
	public class FibonacciCalculatingEventArgs
	{

		public int Position { get; set; }

		public bool Cancel { get; set; } = false;

	}
}
