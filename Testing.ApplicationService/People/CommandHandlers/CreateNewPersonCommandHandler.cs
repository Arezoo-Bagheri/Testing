using Testing.ApplicationService.People.Commands;
using Testing.Core.Domain.People.Entity;
using Testing.Core.Domain.Repositories;

namespace Testing.ApplicationService.People.CommandHandlers
{
    public class CreateNewPersonCommandHandler
    {
        private readonly IPersonCommandRepository _repository;

        public CreateNewPersonCommandHandler(IPersonCommandRepository repository)
        {
            _repository = repository;
        }

        public void Handle(CreateNewPersonCommand command)
        {
            var person = Person.Create(command.Id, command.FirstName, command.LastName);
            _repository.Add(person);
        }
    }
}
