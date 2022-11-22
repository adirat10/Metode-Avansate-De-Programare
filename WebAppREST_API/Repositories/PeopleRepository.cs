using Microsoft.AspNetCore.Mvc;
using WebAppREST_API.Data;
using WebAppREST_API.Models;

namespace WebAppREST_API.Repositories
{
    public class PeopleRepository
    {
        public List<Person> people = new List<Person>()
        {
            new Person(){ Id=1,FirstName="Remus",LastName="Pelle",Age=23,Country="Romania",NickName="Nicholas",Ocupation="Prof"}
        };
        private readonly ApplicationDbContext _applicationDbContext;
        public PeopleRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public List<Person> GetFilterAndPaginated(string search, int page, int pageSz)
        {
            int pageSkip = page - 1;
            if (pageSkip == -1)
                pageSkip = 0;
            int pageSize = pageSz;
            if (pageSize == 0)
                pageSize = 10;

            List<Person> people = _applicationDbContext.People
                .ToList()
                .Where(person => SearchInteligent(person, search))
                .ToList();
            people = people
                .Skip(pageSkip * pageSize)
                .Take(pageSize)
                .ToList();
            return people;
        }
        public Person GetOne(int id)
        {
            return _applicationDbContext.People.First(person => person.Id == id);
        }
        public void CreateOne(Person person)
        {
            _applicationDbContext.People.Add(person);
            _applicationDbContext.SaveChanges();
        }
        public void EditOne(int id, Person body)
        {
            Person dbPerson = GetOne(id);

            dbPerson.FirstName = body.FirstName;
            dbPerson.LastName = body.LastName;
            dbPerson.NickName = body.NickName;
            dbPerson.Ocupation = body.Ocupation;
            dbPerson.Country = body.Country;
            dbPerson.Age = body.Age;

            _applicationDbContext.SaveChanges();
        }
        public void DeleteOne(int id)
        {
            Person dbPerson = GetOne(id);
            _applicationDbContext.People.Remove(dbPerson);
            _applicationDbContext.SaveChanges();
        }
        private bool SearchInteligent(Person person, string input)
        {
            if (string.IsNullOrEmpty(input))
                return true;
            // avem nevoie de toate numele separate
            char[] separatori = new char[] { ' ', '-' };
            string numePrenume = $"{person.FirstName} {person.LastName}";
            string[] toateNumele = numePrenume.Split(separatori);

            // si inputul trebuie separat
            string[] inputs = input.Split(separatori);

            for (int i = 0; i < inputs.Length; i++)
            {
                // presupunem ca inputul curent nu apare in nume
                bool ok = false;
                // si verificam daca apare in vreun nume
                for (int j = 0; j < toateNumele.Length; j++)
                    if (toateNumele[j].ToLower().Contains(inputs[i].ToLower()))
                        ok = true;

                if (!ok)
                    return false;
            }
            return true;
        }
    }
}
