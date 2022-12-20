

using System.ComponentModel;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

namespace OOP_Homework
{
    public class Class1
    {
        //                                 Exercise 1
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
                this.Author = Author;
                return;
            }
            public void SetYear(int Year)
            {
                this.Year = Year;
                return;
            }
        }*/

        //                                              Exercise 2
        /*public class Product
        {
            public string Name;
            public double Price;
            public int Quantity;
            public Product(string name, double price, int quantity)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
            }
            public void GetName()
            {
                Console.WriteLine(Name);
                return;
            }
            public void GetPrice()
            {
                Console.WriteLine(Price);
                return;
            }
            public void GetQuantity()
            {
                Console.WriteLine(Quantity);
                return;    
            }
            public void SetName(string name)
            {
                this.Name = name;
                return;
            }
            public void SetPrice(double price)
            {
                this.Price= price;
                return;
            }
            public void SetQuantity(int quantity)
            {
                this.Quantity = quantity;
                return;
            }
        }*/

        //                                           Exercise 3

        /*public class Animal
        {
            public string Name;
            public string Species;
            public string Breed;
            public int Age;
            public string Color;
            public int Weight;
            public bool IsSprayedOrNeutered;

            public Animal(string name, string species, string breed, int age, string color, int weight, bool isSprayedOrNeutered)
            {
                Name = name;
                Species = species;
                Breed = breed; 
                Age = age;
                Color = color;
                Weight = weight;
                IsSprayedOrNeutered=isSprayedOrNeutered;
            }
            public string GetName()
            {
                return Name;
            }
            public string GetSpecies()
            {
                return Species;
            }
            public string GetBreed()
            {
                return Breed;
            }
            public int GetAge()
            {
                return Age;
            }
            public string GetColor()
            {
                return Color;
            }
            public int GetWeight()
            {
                return Weight;
            }
            public bool IsSprayedOrNot()
            {
                if(IsSprayedOrNeutered==true)
                
                return true;
                else
                    return false;
            }

            public string SetName(string name)
            {
                this.Name = name;
                return Name;
            }
            public string SetSpecies(string species)
            {
                this.Species = species;
                return Species;
            }
            public string SetBreed(string breed)
            {
                this.Breed=breed;
                return Breed;
            }
            public int SetAge(int age)
            {
                this.Age = age;
                return Age;
            }
            public string SetColor(string color)
            {
                this.Color = color;
                return Color;
            }
            public int SetWeight(int weight)
            {
                this.Weight = weight;
                return Weight;
            }
            public bool SetIsSprayedOrNot(bool isSprayedOrNeutered)
            {
                this.IsSprayedOrNeutered = isSprayedOrNeutered;
                return IsSprayedOrNeutered;
            }
        }*/

        //                                        Exercise 4

        /*public class Calculator
        {
            public int x; 
            public int y;
            public Calculator()
            {
                x = 0;
                y = 0;
            }

            public int Add(int x, int y)
            {
                return x + y;
            }
            public int Substract(int x, int y)
            {
                return x - y;
            }
            public int Multiply(int x, int y)
            {
                return x * y;
            }
            public int Divide(int x, int y)
            {
                return x / y;
            }
            public double Power(double x, double y)
            {
                return Math.Pow(x,y);
            }
            public double SquareRoot(double x)
            {
                return Math.Sqrt(x);
            }

        }*/

        //                                         Exercise 5
        /*public class Student
          {
            public string FirstName;
            public string LastName;
            public int StudentId;
            public double GPA;

            public Student(string FirstName, string LastName, int StudentId, double GPA)
            {
                this.FirstName = FirstName;
                this.LastName = LastName;
                this.StudentId = StudentId;
                this.GPA = GPA;
            }
            public string GetFullName()
            {
                return FirstName + " " + LastName;
            }
            public bool HasHonorus()
            {
                if(GPA > 3.5)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public class SubjectTought
        {
            public string Subject1;
            public string Subject2;
            public SubjectTought(string Subject1, string Subject2)
            {
                this.Subject1 = Subject1;
                this.Subject2 = Subject2;

            }
             
        }
        public class Faculty
        {
            public string firstName;
            public string lastName;
            public int employeeId;
            public List<SubjectTought> subjectsTought=new List<SubjectTought>();
        public Faculty(string firstName, string lastName, int employeeId, List<SubjectTought> subjectTought)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.employeeId = employeeId;
                this.subjectsTought = subjectTought;
            }

            public string GetFullName()
            {
                return firstName + " " + lastName;
            }
            public void GetSubjectsTought()
            {
                Console.WriteLine(subjectsTought[1]);
                Console.WriteLine(subjectsTought[2]);

            }
        } 
        public class University
        {
            public string Name;
            public List<Student> students = new List<Student>();
            public List<Faculty> faculty = new List<Faculty>();
            public University(string name, List<Student> students, List<Faculty> faculty)
            {
                Name = name;
                this.students = students;
                this.faculty = faculty;
            }
            public void AddStudent(Student john)
            {
                students.Add(new Student(" "," ", 0, 0.0));
            }
            public void GetStudentCount()
            {
                Console.WriteLine(students.Count); 
            }
            public void GetFacultyCount()
            {
                Console.WriteLine(faculty.Count);
            }
        }*/

        //                                   Exercise 6

        public class College
        {
            public string Name;
            public int FoundedYear;
            public string City;

            public College()
            {
                Name = "Unknown";
                FoundedYear = 0;
                City = "Unknown";
            }
        }

        public class Student
        {
            public string Name;
            public DateTime StartDate;
            public DateTime EndDate;
            public College college;
            public DateTime BirthDate;

            public Student( string Name, DateTime StartDate, DateTime EndDate, College college, DateTime BirthDate)
            {
                this.Name = Name;  
                this.StartDate = StartDate;
                this.EndDate = EndDate;
                this.college = college;
                this.BirthDate = BirthDate;
               
            }
                public string IsStillStudent()
            {
                if(EndDate>DateTime.Now)
                {
                    return "True";
                }
                else
                    return "False";
            }

            public void GetAge()
            {
                Console.WriteLine(BirthDate- DateTime.Now);
            }
             
            public void Print()
            {
                Console.WriteLine(Name, StartDate, EndDate, college, BirthDate);
            }
        }

        public class Professor
        {
            public string Name;
            public string Faculty;
            public string Specuialization;
            

            public List<string> StudentsWhoGiveTheirDegree2;

            public Professor(string name, string faculty, string specuialization, List<string> studentsWhoGiveTheirDegree2)
            {
                Name = name;
                Faculty = faculty;
                Specuialization = specuialization;
                StudentsWhoGiveTheirDegree2 = studentsWhoGiveTheirDegree2;
            }
        }

        /*Create a class Professor with multiple constructors to initiliaze the following values:
- Name
- Faculity
- Specialization
- StudentsWhoGiveTheirDegree - List of students who give their degree

We will have two constructors:
    - name, faculity, specialization
    - name, faculity, specialization, studentsWhoGiveTheirDegree*/






    }




















}
 
