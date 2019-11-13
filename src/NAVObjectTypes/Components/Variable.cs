using System;
using System.Collections.Generic;

namespace NavCodeReferenceGenerator
{
	public class Variable
	{
		public Variable(string name, string datatype)
		{
			this.name = name;
			this.datatype = datatype;
		}

		public Variable(string name, string datatype, string source)
		{
			this.name = name;
			this.datatype = datatype;
			this.source = source;
		}

		public string name { get; set; }
		public string datatype { get; set; }
		public string source { get; set; }
	}
}

