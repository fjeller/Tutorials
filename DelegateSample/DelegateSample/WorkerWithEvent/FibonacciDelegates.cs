using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateSample.WorkerWithEvent
{

	public delegate void FibonacciCalculatedDelegate( object sender, FibonacciCalculatedEventArgs e );

	public delegate void FibonacciCalculatingDelegate( object sender, FibonacciCalculatingEventArgs e );

}
