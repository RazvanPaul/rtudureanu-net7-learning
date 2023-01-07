
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Transactions;
using static System.Net.Mime.MediaTypeNames;

namespace OOP
{
    /*public class Car
    {
        public string model;
        public int year;
        public string color;
        public int mileage;

        public Car(string model, int year, string color, int mileage)
        {
            this.model = model;
            this.year = year;
            this.color = color;
            this.mileage = mileage;
        }

        public string GetModel()
        {
            return model;
        }
        public int GetYear()
        {
            return year;
        }
        public string GetColor()
        {
            return color;
        }
        public int GetMileage()
        {
            return mileage;
        }
       public void Drive()
        {
            mileage += 10;
        }
    }*/

    /*public class Author
    {
        public string name;
        public string email;
        public string country;

        public Author(string name, string email, string country)
        {
            this.name = name;
            this.email = email;
            this.country = country;
        }

        public void GetDetails()
        {
            Console.WriteLine($"Numele autorului este {name}, adresa sa de email este {email}, iar tara din care provine este{country}");
        }
        
        }*/

    /* public class Person

 {
     public string FirstName;
     public string LastName;
     public int Age;
     public string Gender;

     public Person(string FirstName, string LastName, int Age, string Gender)
     {
         this.FirstName = FirstName;
         this.LastName = LastName;   
         this.Age = Age;
         if (Gender != "male" && Gender != "female")
             throw new Exception("The gender is not valid");
         this.Gender = Gender;
     }
     public void Print()
     {
         Console.WriteLine($"Hi. my name is {LastName} {FirstName} and I am a {Age} years old {Gender}");
         return;
     }
 }*/

    /*public class Book
    {
        public string Title;
        public string Author;
        public int Year;

        public Book(string title, string author, int year)
        {
            this.Title = title;
            this.Author = author;
            this.Year = year;
        }
        public void GetTitle()
        {
            Console.WriteLine(Title);
            return; 
        }
        public void GetAuthor()
        {
            Console.WriteLine(Author);
            return;
        }
        public void GetYear()
        {
            Console.WriteLine(Year);
            return;
        }
        public void SetTitle(string Title)
        {
            this.Title = Title;
            return;
        }
        public void SetAuthor(string Author)
        {
            this.Author= Author;
            return;
        }
        public void SetYear(int Year)
        {
            this.Year = Year;
            return;
        }
       }*/

    /*public class Autor
    {
        public string Name;
        public string Email;
        public string Country;
        public string Name { get; set; }
      
        public string Email
            { get { return this.Email; } set { this.Email = value; } }
        public string Country
        {
            get { return this.Country; } set { this.Country = value; } 
        }

        public void Print()
        {
            Console.WriteLine(Name + " "+ Email + " " + Country);
            return;
        }
        
    }*/

    /*public class BankAccount
    {
        public int AccountNumber
        {
            get { return this.AccountNumber; }
            set { this.AccountNumber = value; }
        }
        
        public string AccountHolder
        {
            get { return this.AccountHolder; }
            set { this.AccountHolder = value; }
        }
        public double Balance {get;set;}
       
        public List<string> Transactions=new List<string>();
        

        public BankAccount(int AccountNumber, string AccountHolder, double Balance)
        {
            this.AccountNumber = AccountNumber;
            this.AccountHolder = AccountHolder;
            this.Balance = Balance;
        }

        public void Deposit(int amount)
        {
            Balance+= amount;
            string messageDeposit = $"Deposited $ {amount}";
            Transactions.Add(messageDeposit);
        }
        public void Withdraw(int amount)
        {
            Balance -= amount;
            string messageWithdraw = $"Withdrew $ {amount}";
            Transactions.Add(messageWithdraw);
        }
        public double GetBalance()
        {

            return this.Balance;
        }
        public void GetTransactionHistory()
        {
            Console.WriteLine(Transactions);
        }
    }*/

    /*public abstract class Shape
    {

        public abstract double GetArea();

        public abstract double GetPerimeter();
       
    }
    public class Circle : Shape
    {
        private double radius;
        private double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        private const double PI = 3.1415;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        
        public override double GetArea()
        {
            return PI * Math.Pow(radius, 2);
        }
        public override double GetPerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double GetArea()
        {
            return width * height;
        }
        public override double GetPerimeter()
        {
            return 2 * width + 2 * height;
        }
    }*/

    /*public class Calender
    {

        public enum days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        public enum months
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December

        }

        public int date
        {
            get;
            set;
        }
        
        public void Print()
        {
            Console.WriteLine($"Today is {days.Monday}, {months.December}, {date}");
            return;

        }

    }*/

    /*public class Exercise
    {
        double x = 2;
        double y = 10;
        public void Calcul(out double y)
        {
            y = x * 2;
            x = 2;
            Console.WriteLine(y);
        }
        
    }*/

}
