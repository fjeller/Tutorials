using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBenchmark.Worker
{
	public static class BenchmarkRunner
	{

		private const string STRING_BASE = "The quick brown fox jumps over the lazy dog ";

		public static TimeSpan GetStringConcatTime(int stringCount)
		{
			Stopwatch watch = Stopwatch.StartNew();

			string concatResult = String.Empty;
			for (int i = 0; i < stringCount; i++)
			{
				concatResult += STRING_BASE;
			}

			watch.Stop();
			File.WriteAllText("string.txt", concatResult);

			return watch.Elapsed;
		}

		public static TimeSpan GetStringBuilderConcatTime(int stringCount)
		{
			Stopwatch watch = Stopwatch.StartNew();

			StringBuilder builder = new StringBuilder(String.Empty);
			for (int i = 0; i < stringCount; i++)
			{
				builder.Append(STRING_BASE);
			}

			string result = builder.ToString();

			watch.Stop();
			File.WriteAllText("stringbuilder.txt", result);

			return watch.Elapsed;
		}

	}
}
