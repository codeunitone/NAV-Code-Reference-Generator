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
			// name pos 1 till first @
			this.name = inputString.Substring(0,inputString.IndexOf("@"));

			// datatype
			string datatype = inputString.Substring(inputString.IndexOf(":")+2);
			int nextSpacePos = datatype.IndexOf(" ");
			if (nextSpacePos > -1)
			{
				this.datatype = datatype.Substring(0,nextSpacePos).TrimEnd(';');
			}
			else
			{
				this.datatype = datatype.TrimEnd(';');
			}
		}
	}
}

