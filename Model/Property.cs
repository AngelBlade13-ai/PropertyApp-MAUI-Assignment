namespace PropertyApp.Model
{
    public class Property
    {
        public string DefaultImage { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public List<string> Images { get; set; } = new List<string>();
    }
}