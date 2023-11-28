using Testing.Core.Domain.People.Events;
using Testing.Core.Domain.People.Exceptions;
using Zamin.Core.Domain.Entities;

namespace Testing.Core.Domain.People.Entity
{
    public class Person : AggregateRoot
    {
        public string PersonId { get; set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        private Person() { }

        public static Person Create(long id, string firstName, string lastName)
        {
            if (id == null)
                throw new InvalidPersonIdException("PersonIdIsNull");

            if (string.IsNullOrEmpty(firstName))
                throw new InvalidFirstNameException("FirstNameIsNull");


            if (string.IsNullOrEmpty(lastName))
                throw new InvalidLastNameException("LastNameIsNull");

            var person = new Person
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName
            };

            person.AddEvent(new PersonCreated(person.Id, person.FirstName, person.LastName));
            return person;
        }
    }
}
