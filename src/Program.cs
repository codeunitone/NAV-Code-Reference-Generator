using System;

namespace NavCodeReferenceGenerator
{
	class Program
	{
		static void Main(string[] args)
		{
			Analyze.analyzeFile("ExampleFiles//TAB18.TXT");
			Analyze.analyzeFile("ExampleFiles//TAB27.TXT");
		}
	}
}
