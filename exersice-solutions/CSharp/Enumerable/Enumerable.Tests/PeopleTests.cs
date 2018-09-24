using System;
using Xunit;

namespace Enumerable.Tests
{
    public class PeopleTests
    {
        [Fact]
        public void IEnumerator_Test()
        {
            Person[] personArray = {
                new Person("John", "Smith"),
                new Person("Jim", "Johnson"),
                new Person("Sue", "Rabon")
            };

            Person[] expected = {
                new Person("John", "Smith"),
                new Person("Jim", "Johnson"),
                new Person("Sue", "Rabon")
            };

            int i = 0;
            People peopleList = new People(personArray);
            foreach(var person in personArray)
            {
                Assert.True(person.Equals(expected[i]));
                i++;
            }
        }
    }
}
