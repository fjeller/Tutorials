using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateSample.Worker
{
	public class FibonacciCreator
	{

		private int CalculateFibonacci( int position )
		{
			if ( position <= 2 )
			{
				return 1;
			}

			return CalculateFibonacci( position - 1 ) + CalculateFibonacci( position - 2 );
		}

		public void WriteFibonacciSequence( int count, FibonacciCalculatedCallback callback )
		{
			for ( int i = 1; i <= count; i++ )
			{
				if ( callback != null )
				{
					callback( i, CalculateFibonacci( i ) );
				}
			}
		}

	}
}
