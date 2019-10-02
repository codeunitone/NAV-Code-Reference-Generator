using System;
using Newtonsoft.Json;

namespace NavCodeReferenceGenerator
{
	public static class JsonGenerator
	{
		public static void Generate(object table)
		{
			string json = JsonConvert.SerializeObject(table, Formatting.Indented);
			Console.WriteLine(json);
		}
	}
	
}