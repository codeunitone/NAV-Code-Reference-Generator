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
			// set name
			name = ExtractProcedureName(content[0]);
			
			// set local variables
			if (content.Length > 1)
			{
				List<Variable> variableList = new List<Variable>();
				// statrting from 2 because first item is PROCEDURE... and second is always VAR. variables starting on third position
				for (int i = 2; i < content.Length; i++)
				{
					variableList.Add(new Variable(content[i]));
				}
				localVariables = variableList;
			}
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