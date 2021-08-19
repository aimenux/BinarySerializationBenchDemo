using FluentAssertions;
using LibFour;
using LibFour.Models;
using Xunit;

namespace LibThreeTests
{
    public class LibFourBinarySerializerTests
    {
        [Fact]
        public void Should_Serialize_And_Deserialize()
        {
            // arrange
            var employeeBefore = new Employee
            {
                Id = 1,
                FirstName = "John",
                LastName = "Snow",
                Title = "Engineer",
                Address = new Address
                {
                    City = "Paris",
                    Country = "France"
                }
            };

            var serializer = new LibFourBinarySerializer();

            // act
            using var stream = serializer.Serialize(employeeBefore);
            var employeeAfter = serializer.Deserialize<Employee>(stream);

            // assert
            employeeAfter.Should().NotBeNull();
            employeeAfter.Should().BeEquivalentTo(employeeBefore);
        }
    }
}
