using Patterns.Factory;
using Patterns.Factory.Concrete;
using Xunit;

namespace Patterns.Tests.Factory
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            ITypeAdapterFactory typeAdapterFactory = new AutomapperTypeAdapterFactory();
            TypeAdapterFactory.SetCurrent(typeAdapterFactory);
            var adapter = TypeAdapterFactory.CreateAdapter();

            Person person = new Person { FirstName = "John", LastName = "Doe" };
            PersonDTO personDTO = adapter.Adapt<PersonDTO>(person);
            Assert.Equal("John", personDTO.FirstName);
            Assert.Equal("Doe", personDTO.LastName);

        }
    }
}
