//       Exercise 1

/*BankAccount MyAccount = new BankAccount(123456, "Gheorghe", 10000);
MyAccount.Deposit(400);
MyAccount.Withdraw(600);
Console.WriteLine(MyAccount.GetBalance());
List<string> transactins = MyAccount.GetTransactionsHistory();
foreach (string transaction in transactins)
{
    Console.WriteLine(transaction);
}
MyAccount.AccountNumber = 654321;
MyAccount.AccountHolder = "Vasile";
Console.WriteLine(MyAccount.AccountNumber);
Console.WriteLine(MyAccount.AccountHolder);*/

//            Exercise 2

/*Book book = new Book("For whom the bell toll", "Ernest Hemingway", 420, 146);
Console.WriteLine(book.GetTitle());
Console.WriteLine(book.GetAuthor()); 
Console.WriteLine(book.GetPageCount()); 
Console.WriteLine(book.GetCurrentPage()); 

book.NextPage();
Console.WriteLine(book.GetCurrentPage()); 

book.NextPage();
book.NextPage();
book.NextPage();
Console.WriteLine(book.GetCurrentPage()); 

book.PreviousPage();
Console.WriteLine(book.GetCurrentPage());
book.Title = "The Fiesta";
book.Author = "Ernest Hemingway (revised by Jane Austen)";
Console.WriteLine(book.GetTitle());
Console.WriteLine(book.GetAuthor());*/

//           Exercise 3

/*Rectangle rectangle1 = new Rectangle("Green", 6, 8);
Rectangle rectangle2 = new Rectangle("Yellow", 10, 12);
Circle circle1 = new Circle("Purple", 3);
Circle circle2 = new Circle("Orange", 5);
List<Shape> shapes=new List<Shape> { rectangle1, rectangle2, circle1, circle2 };
foreach (Shape shape in shapes)
{
    shape.CalculateArea();
}
shapes.Sort((shape1, shape2) => shape2.Area.CompareTo(shape1.Area));

foreach (Shape shape in shapes)
{
    Console.WriteLine(shape.Color + ": " + shape.Area);
}
double totalPerimeter = 0;
foreach(Shape shape in shapes)
{
    totalPerimeter+=shape.GetPerimeter();
}
Console.WriteLine("Total perimeter: " + totalPerimeter + " inches");*/

//             Exercise 4
/*using System;
using static Employee;

Manager manager = new Manager("John Doe", 35, 50000, Department.HR);
Developer developer = new Developer("Jane Smith", 28, 30000, new List<string> { "C#", "JavaScript" }, false);
Console.WriteLine(manager.CalculateBonus()); 
Console.WriteLine(developer.CalculateBonus()); 

Console.WriteLine(manager.GetContactInfo());
Console.WriteLine(developer.GetContactInfo());*/

//         Exercise 5
/*using System;

BankAccount account1 = new BankAccount(123456,"John Doe",1000);
BankAccount account2 = new BankAccount(654321, "Jane Smith", 2000);

account1.Deposit(500);
account2.Withdraw(1000);

Console.WriteLine(account1.Balance); 
Console.WriteLine(account2.Balance); 

Console.WriteLine(account1.GetInterest()); 
Console.WriteLine(account2.GetInterest());

Console.WriteLine(Bank.GetNumAccounts()); */

//       Exercise 6

/*IShape circle = new Circle(5);
IShape rectangle = new Rectangle(10, 5);
circle.CalculateArea();
rectangle.CalculateArea();
IColor circleColor = (IColor)circle;
circleColor.Color = "Red";
IColor rectangleColor = (IColor)rectangle;
rectangleColor.Color = "Blue";
Console.WriteLine(circleColor.Color);
Console.WriteLine(rectangleColor.Color);*/


