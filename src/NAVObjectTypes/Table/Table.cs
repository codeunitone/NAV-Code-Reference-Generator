namespace NavCodeReferenceGenerator
{
	public class Table
	{
		public Table(string id, string name) 
		{
			this.id = id;
			this.name = name;
		}

		public string id { get; set; }

		public string name { get; set; }
	}
}