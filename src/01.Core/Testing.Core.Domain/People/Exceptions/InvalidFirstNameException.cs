using Zamin.Core.Domain.Exceptions;

namespace Testing.Core.Domain.People.Exceptions
{
    public class InvalidFirstNameException : InvalidEntityStateException
    {
        public InvalidFirstNameException(string message, params string[] parameters) : base(message, parameters)
        {
        }
    }

}
