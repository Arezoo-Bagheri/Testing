using Shouldly;
using Testing.ApplicationService.People.CommandHandlers;
using Testing.ApplicationService.People.Commands;
using Xunit;


namespace Testing.IntegrationTests.ApplicationService.People
{
    public class CreateNewPersonCommandHandlerTests : IClassFixture<PersonCommandRepositoryFixture>
    {
        PersonCommandRepositoryFixture fixture;

        public CreateNewPersonCommandHandlerTests(PersonCommandRepositoryFixture fixture)
        {
            this.fixture = fixture;
        }

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

            var commandHandler = new CreateNewPersonCommandHandler(fixture.PersonCommandRepository);

            // Act 
            commandHandler.Handle(command);

            // Assert
            var person = fixture.DbContext.People.FirstOrDefault(c => c.Id == command.Id);

            person.ShouldNotBeNull();
            person.FirstName.ShouldBe(command.FirstName);
            person.LastName.ShouldBe(command.LastName);
        }

    }
}
