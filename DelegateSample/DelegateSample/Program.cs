using DelegateSample.Worker;
using DelegateSample.WorkerWithEvent;
using Microsoft.VisualBasic.CompilerServices;
using System;

namespace DelegateSample
{
	class Program
	{
		static void Main( string[] args )
		{
			//FibonacciCreator creator = new FibonacciCreator();

			////FibonacciCalculatedCallback callback = DoSomething;
			////callback += DoSomeOtherThing;

			//creator.WriteFibonacciSequence(10, ( x, y ) => Console.WriteLine( $"Wert an Position {x} ist {y}. " ) );

			FibonacciCreatorWithEvent fiboCreator = new FibonacciCreatorWithEvent();
			fiboCreator.FibonacciCalculated += HandleFibonacciCalculated;
			fiboCreator.FibonacciCalculating += HandleFibonacciCalculating;
			fiboCreator.WriteFibonacciSequence( 10 );

			//public static void DoSomething( int pos, int val )
			//{
			//	Console.Write( $"Wert an Position {pos} ist {val}. " );
			//}

			////public static void DoSomeOtherThing( int pos, int val )
			////{
			////	Console.WriteLine( "Juhu!" );
			////}
		}

		private static void HandleFibonacciCalculating( object sender, FibonacciCalculatingEventArgs e )
		{
			e.Cancel = e.Position == 5;
		}

		private static void HandleFibonacciCalculated( object sender, FibonacciCalculatedEventArgs e )
		{
			Console.WriteLine( $"Wert an Position {e.Position} ist {e.Value}. " );
		}
	}
}
