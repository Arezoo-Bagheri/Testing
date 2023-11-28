using Shouldly;
using Testing.Core.Domain.People.Entity;
using Testing.Core.Domain.People.Events;
using Testing.Core.Domain.People.Exceptions;

namespace Testing.UnitTests.Domain.People.Entity
{
    public class PersonTests
    {
        [Fact]
        public void When_pass_correct_values_To_Factory_expect_person_create()
        {

            // Arrange
            string firstName = "Arezoo";
            string lastName = "Bagheri";
            long id = 1;


            // Act
            var person = Person.Create(id, firstName, lastName);

            // Assert
            person.ShouldNotBeNull();
            person.Id.ToString().ShouldNotBeNull();
            person.Id.ShouldBe(id);
            person.FirstName.ShouldBe(firstName);
            person.LastName.ShouldBe(lastName);

            person.GetEvents().Count().ShouldBe(1);
            var @event = person.GetEvents().FirstOrDefault();

            @event.ShouldBeOfType<PersonCreated>();
        }

        //[Fact]
        //public void When_pass_invalid_business_id_to_factory_expect_invalid_person_id_exception()
        //{
        //    // Arrange
        //    string firstName = "Arezoo";
        //    string lastName = "Bagheri";
        //    long id = 3;

        //    // Act
        //    var invalidPersonIdException = Record.Exception(() => Person.Create(id, firstName, lastName));

        //    // Assert
        //    invalidPersonIdException.ShouldBeNull();
        //    invalidPersonIdException.ShouldBeOfType<InvalidPersonIdException>();
        //}
    }
}
