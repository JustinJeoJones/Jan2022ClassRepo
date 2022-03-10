namespace ApiDemo.Models
{
    public class Book
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }

        //Static methods/properties that emulate a database
        private static List<Book> Library = new List<Book>();
        private static int NextId = 1;
        public static Book AddBook(string _title, string _category)
        {
            Book newbook = new Book()
            {
                id = NextId,
                Title = _title,
                Category = _category
            };
            NextId++;
            Library.Add(newbook);
            return newbook;
        }

        public static List<Book> GetAll()
        {
            return Library;
        }

        public static Book FindById(int _id)
        {
            return Library.Find(b => b.id == _id);
        }

        public static List<Book> FindByCategory(string _category)
        {
            return Library.Where(b => b.Category.ToLower().Trim() == _category.ToLower().Trim()).ToList();
        }
    }
}
