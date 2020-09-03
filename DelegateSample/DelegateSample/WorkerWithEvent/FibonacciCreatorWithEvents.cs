namespace DelegateSample.WorkerWithEvent
{
	public class FibonacciCreatorWithEvent
	{

		public event FibonacciCalculatedDelegate FibonacciCalculated = ( s, e ) => { };
		public event FibonacciCalculatingDelegate FibonacciCalculating = ( s, e ) => { };

		private int CalculateFibonacci( int position )
		{
			if ( position <= 2 )
			{
				return 1;
			}

			return CalculateFibonacci( position - 1 ) + CalculateFibonacci( position - 2 );
		}

		public void WriteFibonacciSequence( int count )
		{
			for ( int i = 1; i <= count; i++ )
			{
				FibonacciCalculatingEventArgs e = new FibonacciCalculatingEventArgs()
				{
					Position = i
				};
				OnFibonacciCalculating(e);
				if ( e.Cancel )
				{
					continue;
				}
				int result = CalculateFibonacci( i );
				OnFibonacciCalculated( i, result );
			}
		}

		private void OnFibonacciCalculated( int position, int value )
		{
			FibonacciCalculatedEventArgs e = new FibonacciCalculatedEventArgs( position, value );
			OnFibonacciCalculated( this, e );
		}

		private void OnFibonacciCalculating(FibonacciCalculatingEventArgs e)
		{
			OnFibonacciCalculating( this, e );
		}

		protected virtual void OnFibonacciCalculated( object sender, FibonacciCalculatedEventArgs e )
		{
			FibonacciCalculated( sender, e );
		}

		protected virtual void OnFibonacciCalculating( object sender, FibonacciCalculatingEventArgs e )
		{
			FibonacciCalculating( sender, e );
		}
	}
}
