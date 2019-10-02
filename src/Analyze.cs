using System;
using System.IO;
using System.Text.RegularExpressions;

namespace NavCodeReferenceGenerator
{
	static public class Analyze
	{
		public static void analyzeFile(string fileName)
		{
			string[] fileContent = File.ReadAllLines(fileName);

			Regex tableRegEx = new Regex("^OBJECT Table\\s\\d[0-9]{0,}");

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

			Console.WriteLine("Id:{0}",table.id);
			Console.WriteLine("name:{0}",name);

			JsonGenerator.Generate(table);
		}
	}
}
