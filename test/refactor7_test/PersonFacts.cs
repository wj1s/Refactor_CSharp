using Xunit;
using refactor7;

namespace refactor7_test
{
    public class PersonFacts
    {
        [Fact]
        public void should_get_name()
        {
            var person = new Person("a", "1", "2");
            Assert.Equal("a(1) 2",person.ToString());
        }

        [Fact]
        public void should_get_manager()
        {
            var manager = new Person("b", "2", "3");
            var person = new Person("a", "1", "2", new Department(manager));
            Assert.Equal(manager, person.GetDepartment().GetManager());
        }
    }
}