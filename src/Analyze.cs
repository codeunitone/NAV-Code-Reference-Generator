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

			List<Procedure> proceduresList = new List<Procedure>();
			for (int i = 0; i < fileContent.Length; i++)
			{
				Regex procedureRegEx = new Regex("PROCEDURE\\s[A-Za-z0-9]{0,}\\@\\d[0-9]{0,}\\(");
				if (procedureRegEx.IsMatch(fileContent[i]) == true)
				{
					// proceduresList.Add(new Procedure("Function1") {localVariables = localVariables});
					proceduresList.Add(new Procedure(fileContent[i]));
				}
				table.procedures = proceduresList;
			}

			string fileName = "TAB" + table.id + ".json";
			JsonGenerator.Generate(table,fileName);
		}
	}
}
