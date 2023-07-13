namespace iainsallah.Models
{
	public class Instrument
	{
        public string Id { get; set; }
		public string? Name { get; set; }

        public Instrument()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
