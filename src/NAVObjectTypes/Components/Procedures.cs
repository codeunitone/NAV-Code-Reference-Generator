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
			Regex procedureRegEx = new Regex("PROCEDURE\\s[A-Za-z0-9]{0,}\\@\\d[0-9]{0,}\\(");
			if (procedureRegEx.IsMatch(name) == true)
			{
				name = ExtractProcedureName(name);
			}

			this.name = name;
		}

		public string name { get; set; }

		public List<Variable> localVariables { get; set; }

		string ExtractProcedureName(string inputString)
		{
			var startPos = inputString.IndexOf("PROCEDURE") + 10;
			var stringLength = inputString.IndexOf("@") - startPos;
			var procedureName = inputString.Substring(startPos,stringLength);

			return procedureName;
		}
	}
}