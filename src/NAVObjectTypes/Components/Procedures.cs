using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace NavCodeReferenceGenerator
{
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
}