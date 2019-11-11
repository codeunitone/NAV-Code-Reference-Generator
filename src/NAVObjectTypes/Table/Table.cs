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
}