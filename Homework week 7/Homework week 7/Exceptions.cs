
namespace Homework_week_7
{
    public class InvalidDataException : Exception
    {
        public InvalidDataException(string? message) : base(message)
        {

        }

    }

    public class BlankNameException : Exception 
    {
        public BlankNameException(string? message) : base(message)
        { 
        
        }
    }

    public class FormatException1 : Exception
    {
        public FormatException1(string? message) : base(message)
        { }
    }

    public class OverflowException : Exception
    {
        public OverflowException(string? message) : base(message)
        { }
    }

    public class DividedByZeroException : Exception
    {
        public DividedByZeroException(string? message) : base(message)
        { }
    }

    
}


