namespace Domain
{
	public class Category
	{
		public int Id { get; set; }
		public string? Name { get; set; }

		public Tier Layer { get; set; }

		public Category(int id, string? name, Tier layer)
		{
			Id = id;
			Name = name;
			Layer = layer;
		}
	}
	public enum Tier
	{
		Low = 1,
		Mid = 2,
		High = 3
	}
}