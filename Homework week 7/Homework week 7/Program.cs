using Homework_week_7;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.X86;
using static System.Net.Mime.MediaTypeNames;
using InvalidDataException = Homework_week_7.InvalidDataException;

//            Exercise 1

/*Console.WriteLine("Insert the current date:");
Console.Write("Enter a day: ");
int day = int.Parse(Console.ReadLine());
Console.Write("Enter a month: ");
int month = int.Parse(Console.ReadLine());
Console.Write("Enter a year: ");
int year = int.Parse(Console.ReadLine());

DateTime inputtedDate = new DateTime(year, month, day);
DateTime currentDate = DateTime.Now;
if(inputtedDate>currentDate)
{
    throw new InvalidDataException("The date you inserted is in the future");
}*/

//                  Exercise 2

/*List<string> Names = new List<string>();
Console.WriteLine("Please insert 5 names:");
string name;
for (int i = 0; i < 5; i++)
{
    name = Console.ReadLine();
    Names.Add(name);
    if (Names.Contains(""))
    {
        throw new BlankNameException("One of the names you inserted is blank");
    }
}*/

//                   Exercise 3

/*List<int> Numbers = new List<int>();
Console.WriteLine("Enter a list of numbers:");
int number;
try
{
    for (int i = 0; i < 5; i++)
    {
        number = Convert.ToInt32(Console.ReadLine());
        Numbers.Add(number);

    }
}
catch ( System.FormatException)
{
    Console.WriteLine("The input was not in the correct format");
}

try
{
    int total = Numbers.Sum(x => Convert.ToInt32(x));
    Console.WriteLine("Sum: " + total);
    double average = Numbers.Average(z => Convert.ToInt32(z));
    Console.WriteLine("Average: " + average);
}
catch (System.OverflowException )
{
    Console.WriteLine("The arithmetic operation resulted in an overflow");
}
catch (System.InvalidOperationException)
{
    Console.WriteLine("Attempted to divide by zero.");
}*/

//                   Exercise 4

/*string path = @"C:\Users\tudur\Desktop\Test.txt";
try
{
    string lines = File.ReadAllText(@"C:\Users\tudur\Desktop\Test.txt");
    Console.WriteLine(lines);
}
catch (Exception ex)
{
    if (!File.Exists("Test.txt"))
    {       
        Console.WriteLine("The file has just been created. Please type here the text you want in the file:");
        string input = Console.ReadLine();
        File.WriteAllText(@"C:\Users\tudur\Desktop\Test.txt", input);
    }
}

var fileLength = new FileInfo(path);
try
{
    if (fileLength.Length == 0)
    {
        Console.WriteLine("The file is currently empty. Please type here the text you want in the file:");
        string input = Console.ReadLine();
        File.WriteAllText(@"C:\Users\tudur\Desktop\Test.txt", input);
    }
}
catch(IOException)
{
    Console.WriteLine("Error. Please try again.");
}*/

//                   Exercise 5

/*Console.WriteLine("Insert the current date:");
Console.Write("Enter a day: ");
int day = int.Parse(Console.ReadLine());
Console.Write("Enter a month: ");
int month = int.Parse(Console.ReadLine());
Console.Write("Enter a year: ");
int year = int.Parse(Console.ReadLine());
Console.WriteLine("The date you inserted is: " + month+"/" + day + "/" + year);
DateTime inputtedDate = new DateTime(year, month, day);
DateTime currentDate = DateTime.Now;
if (inputtedDate > currentDate)
{
    throw new InvalidDataException("The date you inserted is in the future");
}
Console.WriteLine("The current date and time is: " +currentDate.ToFullDateString());*/

//                   Exercise 6

/*public class ConversionExample
{
    public static void Main(string[] args)
    {
        int n, i;
        int[] a = new int[10];
        Console.Write("Please enter the number you want to be converted to binary: ");
        n = int.Parse(Console.ReadLine());
        for (i = 0; n > 0; i++)
        {
            a[i] = n % 2;
            n = n / 2;
        }
        Console.Write("Binary of the given number= ");
        for (i = i - 1; i >= 0; i--)
        {
            Console.Write(a[i]);
        }
    }
}*/

//                  Exercise 7

/*class Squares
{

    static void Main(string[] args)
    {
        List<int> data = new List<int>();
        List<int> evenNumbers = new List<int>();
        int sum=0;   
        data.Add(2);
        data.Add(3);
        data.Add(4);
        data.Add(14);
        data.Add(6);
        data.Add(12);
        data.Add(11);

        foreach (var i in data)
        {
            if(i%2==0)
            {
                evenNumbers.Add(i);
            }
        }
        foreach(var i in evenNumbers)
        {
            sum += i * i;
        }
        Console.WriteLine(sum);
    }
}*/

//                     Exercise 8

/*List<int> Numbers = new List<int> { 5, 7, 12, 21, 30 };
List<int> squareNumbers = new List<int>();

Func<int, int> squareFunction = x => x * x;

foreach (int x in Numbers)
{
    int y = x;
    y = x * x;
    squareNumbers.Add(y);
}
foreach(int y in squareNumbers)
{
    Console.WriteLine(y);
}*/

//                   Exercise 10

/*var productsAscending=new List<Product>();
var products = new List<Product> {
  new Product { Name = "Product 1", Category = "Category 1", Price = 10 },
  new Product { Name = "Product 2", Category = "Category 2", Price = 20 },
  new Product { Name = "Product 3", Category = "Category 1", Price = 15 },
  new Product { Name = "Product 4", Category = "Category 3", Price = 5 },
  new Product { Name = "Product 5", Category = "Category 3", Price = 5 }
};

products.Sort((e1,e2)=>e1.Price.CompareTo(e2.Price));
products.ForEach(user => Console.WriteLine(user.Price));
products.Sort((n1, n2) => n1.Name.CompareTo(n2.Name));
products.ForEach(user => Console.WriteLine(user.Name));


public class Product
{
    public string Name;
    public string Category;
    public int Price;
    
}*/



