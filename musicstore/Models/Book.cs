using System.Reflection;

namespace musicstore.Models
{
    public class Book : Product
    {
        private string author;
        private string publisher;
        private short published;
        private string isbn;

        public Book(string title, double price, string author, string publisher, short published, string isbn) : base(title, price)
        {
            this.author = author;
            this.publisher = publisher;
            this.published = published;
            this.isbn = isbn;
        }

        public string Author { get { return author; } set { author = value; } }
        public string Publisher { get {  return publisher; } set {  publisher = value; } }
        public short Published { get {  return published; } set {  published = value; } }
        public string Isbn { get {  return isbn; } set {  isbn = value; } }
    }
}
