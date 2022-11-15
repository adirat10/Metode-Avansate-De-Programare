using WebAppREST_API.Models;

namespace WebAppREST_API.Repositories
{
    public class PeopleRepository
    {
        public List<Person> people = new List<Person>()
        {
            new Person(){ Id=1,FirstName="Remus",LastName="Pelle",Age=23,Country="Romania",NickName="Nicholas",Ocupation="Prof"}
        };
    }
}
