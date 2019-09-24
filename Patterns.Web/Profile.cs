namespace Patterns.Web
{
    public class Profile : AutoMapper.Profile
    {
        public Profile()
        {
            CreateMap<Person, PersonDTO>();

            CreateMap<PersonDTO, Person>();
        }
    }
}
