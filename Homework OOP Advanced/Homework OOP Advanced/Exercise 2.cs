using System.Reflection;

public class Book
{
    private string title;
    private string author;
    public string Title
    {
        get { return this.title; }
        set { this.title = value; }
    }
    public string Author
    {
        get { return this.author; }
        set { this.author = value; }
    }
    private int PageCount { get; set; }
    private int CurrentPage { get; set; }

    public Book(string title, string author, int PageCount, int CurrentPage)
    {
        this.Title = title;
        this.Author = author;
        this.PageCount = PageCount;
        this.CurrentPage = CurrentPage;
    }
    public string GetTitle()
    {
        return title;
        
    }
    public string GetAuthor()
    {
        return author;
    }
    public int GetPageCount()
    {
        return PageCount;
    }
    public int GetCurrentPage()
    {
        return CurrentPage;
    }
    public void NextPage()
    {       
       CurrentPage=CurrentPage+1;
    }
    public void PreviousPage()
    { 
        CurrentPage=CurrentPage-1;
    }
}