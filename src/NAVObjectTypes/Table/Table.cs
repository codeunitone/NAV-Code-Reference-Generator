using System;
using System.Collections.Generic;

namespace NavCodeReferenceGenerator
{
	public class Table
	{
		public Table(string id, string name) 
		{
			this.id = id;
			this.name = name;
		}

		public string id { get; set; }

		public string name { get; set; }

		public List<Variable> globalVariables { get; set; }

		public List<Procedure> procedures { get ; set; }
	}

	public class Procedure
	{
		public Procedure() 
		{
		}
		
		public Procedure(string name) 
		{
			this.name = name;
		}

		public string name { get; set; }

		public List<Variable> localVariables { get; set; }
	}

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