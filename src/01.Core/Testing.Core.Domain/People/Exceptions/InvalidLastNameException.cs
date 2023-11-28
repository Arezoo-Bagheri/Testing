using Zamin.Core.Domain.Exceptions;

namespace Testing.Core.Domain.People.Exceptions
{
    public class InvalidLastNameException : InvalidEntityStateException
    {
        public InvalidLastNameException(string message, params string[] parameters) : base(message, parameters)
        {
        }
    }

}
