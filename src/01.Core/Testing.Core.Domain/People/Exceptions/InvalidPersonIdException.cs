using Zamin.Core.Domain.Exceptions;

namespace Testing.Core.Domain.People.Exceptions
{
    public class InvalidPersonIdException : InvalidEntityStateException
    {
        public InvalidPersonIdException(string message, params string[] parameters) : base(message, parameters)
        {
        }
    }

}
