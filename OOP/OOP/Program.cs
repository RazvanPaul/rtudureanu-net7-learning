
using OOP;

/*Car car = new Car("Audi A4", 2005, "negru", 260000);
Console.WriteLine(car.GetModel());
Console.WriteLine(car.GetYear());
Console.WriteLine(car.GetColor());
Console.WriteLine(car.GetMileage());
car.Drive();
Console.WriteLine(car.GetMileage());*/

/*Author Dickens = new Author("Charles Dickens", "charles_dickens60@gmail.com", "England");
Console.WriteLine(Author.GetDetails());
Person person = new Person("Razvan", "Tudureanu", 24, "male");
person.Print();*/

/*Book book = new Book("War and Peace", "Leo Tolstoy", 1869);
book.GetTitle();
book.GetAuthor();
book.GetYear();
book.SetTitle("The Brothers Karamazov");
book.SetAuthor("Dostoevski");
book.SetYear(1880);
book.GetTitle();
book.GetAuthor();
book.GetYear();*/

/*Author razvan = new Author("Tudureanu", "Paul", "Razvan");
Book carte = new Book("Fratii Karamazov", 1880, "Novel", razvan);
carte.PrintInfo();*/


/*College college=new College();
Student razvan = new Student("Razvan", DateTime.Now.AddYears(-10), DateTime.Now.AddYears(-5), college, DateTime.Now.AddYears(-30));
razvan.Print();*/
/*Autor razvan = new Autor();
{
    razvan.Name = "Razvan";
    razvan.Email = "asd";
    razvan.Country = "Romania";
}
razvan.Print();*/

/*BankAccount myAccount = new BankAccount(123456, "John Doe", 1000);

myAccount.Deposit(500);
myAccount.Withdraw(200);

myAccount.GetBalance();
List<string> transactions = myAccount.GetTransactionHistory();
foreach (string transaction in transactions)
{
    Console.WriteLine(transaction);
}*/

Circle myCircle = new Circle(5);
Rectangle myRectangle = new Rectangle(5, 10);

Console.WriteLine(myCircle.GetArea()); 
Console.WriteLine(myCircle.GetPerimeter()); 

Console.WriteLine(myRectangle.GetArea()); 
Console.WriteLine(myRectangle.GetPerimeter()); 


