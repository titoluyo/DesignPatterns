namespace Patterns.Tests.Factory
{
    public class Profile : AutoMapper.Profile
    {
        public Profile()
        {
            CreateMap<Person, PersonDTO>();
        }
    }
}
