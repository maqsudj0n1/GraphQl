namespace GraphQl.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public int AuthorId { get; set; }

        public Author? Author { get; set; }
    }

    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }

}
