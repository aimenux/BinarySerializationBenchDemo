using FluentAssertions;
using LibOne;
using LibOne.Models;
using Xunit;

namespace LibOneTests
{
    public class LibOneBinarySerializerTests
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

            var serializer = new LibOneBinarySerializer();

            // act
            using var stream = serializer.Serialize(employeeBefore);
            var employeeAfter = serializer.Deserialize<Employee>(stream);

            // assert
            employeeAfter.Should().NotBeNull();
            employeeAfter.Should().BeEquivalentTo(employeeBefore);
        }
    }
}
