using System.Reflection;
using static Employee;

public abstract class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }

    public abstract double CalculateBonus();
    public virtual string GetContactInfo()
    {

        return ($"Name: {Name}, Age: {Age}, Salary: {Salary}");
        
    }
    public enum Department
    {
        HR,
        IT,
        Scales,
        Marketing
    }

    public class Manager : Employee
    { 
        Department department= Department.HR;
        public Manager(string Name, int Age, double Salary, Department department)
        {
            this.department = department;
            this.Name = Name;
            this.Age = Age;
            this.Salary = Salary;
        }
        public override double CalculateBonus()
        {
            double Bonus;
            Bonus = Salary * 0.1;
            return Bonus;
        }
        public override string GetContactInfo()
        {
            return ($"Name: {Name}, Age: {Age}, Salary: {Salary}");

        }
    }
    public class Developer : Employee
    {
        private List<string> Skills= new List<string>();
        private bool IsJunior { get; set; }

        public Developer(string Name, int Age, double Salary, List<string> skills, bool isJunior)
        {
            Skills = skills;
            IsJunior = isJunior;
            this.Name=Name;
            this.Age=Age;
            this.Salary=Salary;
        }
        public override double CalculateBonus()
        {
            double Bonus;
            Bonus= Salary * 0.2;
            return Bonus;
        }
        public override string GetContactInfo()
        {
            return ($"Name: {Name}, Age: {Age}, Salary: {Salary}");
        }
    }






}
