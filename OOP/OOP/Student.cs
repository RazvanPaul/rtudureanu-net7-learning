
namespace OOP
{
    public class Student
    {
        string Name;
        DateTime StartDate;
        DateTime EndDate;
        public College college;
        DateTime BirthDate;

        public Student(string name, DateTime startDate, DateTime endDate, College college, DateTime birthDate)
        {
            this.Name = name;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.college = college;
            this.BirthDate = birthDate;
        }
        public bool IsStillStudent()
        {
            if (EndDate < DateTime.Now)
                return false;
            else
                return true;    
        }
        public int GetAge()
        {
            return DateTime.Now.Year - this.BirthDate.Year;
        }
        public void Print()
        {
            Console.WriteLine($"Name is {this.Name}, age is {this.GetAge} and is going to");
            return;
        }
    }

}   
