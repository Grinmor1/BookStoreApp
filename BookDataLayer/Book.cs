namespace BookDataLayer
{
    public class Book
    {
        public Book()
        {
            Id = IdGenerator.GenerateId();
        }

        public int Id { get; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int NumberPages { get; set; }
        public double Rating { get; set; }
    }
}