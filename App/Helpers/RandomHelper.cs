using System;
using System.Linq;
using EmployeeOne = LibOne.Models.Employee;
using EmployeeTwo = LibTwo.Models.Employee;

namespace App.Helpers
{
    public static class RandomHelper
    {
        private static readonly Random Random = new(Guid.NewGuid().GetHashCode());

        public static EmployeeOne RandomEmployeeOne(int length)
        {
            return new()
            {
                FirstName = RandomString(length),
                LastName = RandomString(length),
                Title = RandomString(length),
                Address = new LibOne.Models.Address
                {
                    City = RandomString(length),
                    Country = RandomString(length)
                }
            };
        }

        public static LibTwo.Models.Employee RandomEmployeeTwo(int length)
        {
            return new()
            {
                FirstName = RandomString(length),
                LastName = RandomString(length),
                Title = RandomString(length),
                Address = new LibTwo.Models.Address
                {
                    City = RandomString(length),
                    Country = RandomString(length)
                }
            };
        }

        private static string RandomString(int length)
        {
            const string chars = @"ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[Random.Next(s.Length)]).ToArray());
        }
    }
}
