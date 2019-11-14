using System;
using System.Collections.Generic;

namespace NavCodeReferenceGenerator
{
	public class Variable
	{
		public Variable(string inputString)
		{
			ExtractDetails(inputString);
		}

		public string name { get; set; }
		public string datatype { get; set; }
		public string source { get; set; }

		void ExtractDetails(string inputString)
		{
			Console.WriteLine(inputString);
			// name pos 1 till first @
			this.name = inputString.Substring(0,inputString.IndexOf("@"));
		}
	}
}

