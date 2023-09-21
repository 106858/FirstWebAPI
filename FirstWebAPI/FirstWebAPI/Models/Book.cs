namespace FirstWebAPI.Models
{
    public class Book
    {
        public int BookID { get; set; }

        public string Title { get; set; } =String.Empty;

        public int Cost { get; set; }

        public string AuthorName { get; set; } = String.Empty;

    }
}
