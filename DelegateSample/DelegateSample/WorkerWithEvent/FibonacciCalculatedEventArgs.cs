using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateSample.WorkerWithEvent
{
	public class FibonacciCalculatedEventArgs
	{

		public int Position { get; set; }

		public int Value { get; set; }

		public FibonacciCalculatedEventArgs( int position, int value )
		{
			Position = position;
			Value = value;
		}

		public FibonacciCalculatedEventArgs()
		{

		}
	}
}
