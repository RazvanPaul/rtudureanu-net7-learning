
namespace OOP
{
    public class Book
    {
        string title;
        int year;
        string genre;
        public Author author;

        public Book(string title, int year, string genre, Author author)
        {
            this.title = title;
            this.year = year;
            this.genre = genre;
            this.author = author ;
        }
        public string GetTitle()
        {
            return title;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Book title is: {title}, year: {year}, genre: {genre} and author is:{author.FirstName} {author.MiddleName} {author.LastName}");
            return;
            
        }
    }
}
