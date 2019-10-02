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
			
			for (int i = 0; i < fileContent.Length; i++)
			{
				if (i == 0)
				{
					if (tableRegEx.IsMatch(fileContent[i]) == true)
					{
						analyzeTable(fileContent);
					}
				}
			}
		}

		static void analyzeTable(string[] fileContent)
		{
			Console.Write("It's a table!");
		}
	}
}