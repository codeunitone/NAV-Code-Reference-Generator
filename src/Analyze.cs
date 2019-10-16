using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace NavCodeReferenceGenerator
{
	static public class Analyze
	{
		public static void analyzeFile(string fileName)
		{
			string[] fileContent = File.ReadAllLines(fileName);

			Regex tableRegEx = new Regex("^OBJECT Table\\s\\d[0-9]{0,}");

			// the first line is always Object Type, ID and Name
			if (tableRegEx.IsMatch(fileContent[0]) == true)
			{
				analyzeTable(fileContent);
			}
		}

		static void analyzeTable(string[] fileContent)
		{
			string id = Regex.Replace(fileContent[0].Substring(13),@"\D","");
			string name = Regex.Replace(fileContent[0].Substring(13),@"\d","");
			
			Table table = new Table(id, name);

			List<Procedure> procedures = new List<Procedure>();
			List<Variable> globalVariables = new List<Variable>();

			globalVariables.Add(new Variable("DocType","Option"));
			globalVariables.Add(new Variable("DocNo","code[20]"));
			globalVariables.Add(new Variable("Customer","Record","18"));
			table.globalVariables = globalVariables;

			List<Variable> localVariables = new List<Variable>();
			localVariables.Add(new Variable("ItemNo","code[20]"));
			localVariables.Add(new Variable("Item","Record","27"));			
			procedures.Add(new Procedure("Function1") {localVariables = localVariables});

			List<Variable> localVariables = new List<Variable>();
			localVariables.Add(new Variable("ItemNo","code[20]"));
			localVariables.Add(new Variable("Item","Record","27"));
			procedures.Add(new Procedure("Function2") {localVariables = localVariables});

			table.procedures = procedures;

			JsonGenerator.Generate(table);
		}
	}
}
