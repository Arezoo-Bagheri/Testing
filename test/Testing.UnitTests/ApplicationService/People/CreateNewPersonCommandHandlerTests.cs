using Moq;
using Testing.ApplicationService.People.CommandHandlers;
using Testing.ApplicationService.People.Commands;
using Testing.Core.Domain.People.Entity;
using Testing.Core.Domain.Repositories;

namespace Testing.UnitTests.ApplicationService.People
{
    public class CreateNewPersonCommandHandlerTests
    {

        [Fact]
        public void When_pass_valid_Input_value_expect_person_create_and_register_in_database()
        {

            // Arrange
            var command = new CreateNewPersonCommand
            {
                Id = 1,
                FirstName = "Arezoo",
                LastName = "Bagheri",
            };

            var moqPersonRepository = new Mock<IPersonCommandRepository>();
            moqPersonRepository.Setup(c => c.Add(It.IsAny<Person>()));
            var handler = new CreateNewPersonCommandHandler(moqPersonRepository.Object);

            // Act
            handler.Handle(command);

            // Assert
            moqPersonRepository.Verify(mock => mock.Add(It.IsAny<Person>()), Times.Once());
        }


    }
}
