using StringBenchmark.Worker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringBenchmark
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			this.lblInfo.Text = String.Empty;
			lblResultString.Text = String.Empty;
			lblResultStringBuilder.Text = String.Empty;
		}

		private int GetStringsCount()
		{
			if (!Int32.TryParse(this.txtStringsCount.Text, out int result))
			{
				result = 10000;  // Default Value
			}

			if (result > 30000)
			{
				result = 30000;
			}

			this.txtStringsCount.Text = result.ToString();
			return result;
		}

		private TimeSpan RunStringBenchmark(int stringsCount)
		{
			this.lblInfo.Text = $"Running Benchmark for String with {stringsCount} Strings";

			TimeSpan result = BenchmarkRunner.GetStringConcatTime(stringsCount);

			return result;
		}

		private TimeSpan RunStringBuilderBenchmark(int stringsCount)
		{
			this.lblInfo.Text = $"Running Benchmark for StringBuilder with {stringsCount} Strings";

			TimeSpan result = BenchmarkRunner.GetStringBuilderConcatTime(stringsCount);

			return result;
		}

		private void RunBenchmark()
		{
			int stringsCount = GetStringsCount();
			TimeSpan stringResult = RunStringBenchmark(stringsCount);
			TimeSpan stringBuilderResult = RunStringBuilderBenchmark(stringsCount);

			// Yes, I know, this is not properly calculated
			this.prbString.Maximum = (int)stringResult.Ticks;
			this.prbStringBuilder.Maximum = (int)stringResult.Ticks;

			this.prbString.Value = (int)stringResult.Ticks;
			this.prbStringBuilder.Value = (int) stringBuilderResult.Ticks;

			this.lblResultString.Text = stringResult.ToString(@"ss\.fffffff");
			this.lblResultStringBuilder.Text = stringBuilderResult.ToString(@"ss\.fffffff");
		}

		private void RunButtonClicked(object sender, EventArgs e)
		{
			this.Height = 400;
			RunBenchmark();
		}
	}
}
