namespace ItemCatalogWebsite.Models
{
    public class Review
    {
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }
        public string ReviewrName { get; set; }
        public string ReviewrEmail { get; set; }
    }
}
