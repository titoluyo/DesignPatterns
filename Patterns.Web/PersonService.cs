using System.Collections.Generic;

namespace Patterns.Web
{
    // Fake Service
    public interface IPersonService
    {
        List<Person> GetPersons();
        Person GetPerson(int id);

        void AddPerson(Person person);
    }
    public class PersonService : IPersonService
    {
        // Simulation/Fake Service
        private List<Person> _persons;

        public PersonService()
        {
            InitializePersons();
        }

        private void InitializePersons()
        {
            if (_persons == null)
            {
                // Person simulates entity that comes from Application layer
                _persons = new List<Person> {
                    new Person { FirstName = "John", LastName = "Doe" },
                    new Person { FirstName = "Alice", LastName = "Cooper" },
                    new Person { FirstName = "Bob", LastName = "Bloggs" }
                };
            }
        }
        public List<Person> GetPersons()
        {
            return _persons;
        }

        public Person GetPerson(int id)
        {
            if (id < 0 || id >= _persons.Count) return null;
            return _persons[id];
        }
        public void AddPerson(Person person)
        {
            _persons.Add(person);
        }

    }
}
