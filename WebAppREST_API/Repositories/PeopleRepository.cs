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
        public List<Person> GetAll()
        {
            return _applicationDbContext.People.ToList();
        }
        public Person GetOne(int id)
        {
            return _applicationDbContext.People.FirstOrDefault(person => person.Id == id);
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
    }
}
