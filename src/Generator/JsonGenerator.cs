using System;
using Newtonsoft.Json;

namespace NavCodeReferenceGenerator
{
	public static class JsonGenerator
	{
		public static void Generate(object table,string fileName)
		{
			string json = JsonConvert.SerializeObject(table, Formatting.Indented);
			System.IO.File.WriteAllText(fileName, json);
		}
	}
	
}