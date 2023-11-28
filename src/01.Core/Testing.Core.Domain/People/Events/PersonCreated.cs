using Zamin.Core.Domain.Events;

namespace Testing.Core.Domain.People.Events
{
    public class PersonCreated : IDomainEvent
    {
        public long Id { get; }

        public string FirstName { get; }

        public string LastName { get; }


        public PersonCreated(long  id , string firstName , string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
