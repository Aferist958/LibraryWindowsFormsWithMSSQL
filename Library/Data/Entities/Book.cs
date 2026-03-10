using System.ComponentModel.DataAnnotations;

namespace Library.Data.Entities
{
    public class Book
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public int YearOfPublucation { get; set; }

        public int Quantity { get; set; }
    }
}
