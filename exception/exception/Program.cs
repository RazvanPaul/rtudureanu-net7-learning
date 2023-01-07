

/*List<string> EmailList = new List<string>();

Console.WriteLine("Insert your emails");
string email=Console.ReadLine();



foreach (string elem in EmailList)
{
    if (email.Length < 0)
    {
        throw new InvalidEmailException("Email is not valid");
    }
    if (!elem.Contains("@")) 
    {
        throw new InvalidEmailException("Email is not valid");
    }
    if (!elem.Contains("."))
    {
        throw new InvalidEmailException("Email is not valid");
    }
}

public class InvalidEmailException : Exception
{
    public InvalidEmailException(string? message) : base(message)
    { }
}*/


List<int> numbers = new List<int>();
for(int i = 0; i < 10; i++)
{
    Console.WriteLine("Introduceti un numar");
    int input=Convert.ToInt32(Console.ReadLine());
    numbers.Add(input);
}

foreach (int input in numbers)
{
    if(input<0)
    {
        throw new InvalidNumberException("Negative number");
    }
}
public class InvalidNumberException : Exception
{
    public InvalidNumberException(string? message) : base(message)
    { }
}