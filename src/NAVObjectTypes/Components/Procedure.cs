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
		
		public Procedure(string[] content) 
		{
			name = ExtractProcedureName(content[0]);
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