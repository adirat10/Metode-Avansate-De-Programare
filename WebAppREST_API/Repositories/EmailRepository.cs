using System.Collections.Generic;
using System.Linq;
using WebAppREST_API.Data;
using WebAppREST_API.Models;

namespace WebAppREST_API.Repositories
{
    public class EmailRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public EmailRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public List<Email> GetAll()
        {
            return _applicationDbContext.Emails.ToList();
        }
        public Email GetOne(int id)
        {
            return _applicationDbContext.Emails.First(emails => emails.Id == id);
        }
        public void CreateOne(Email email)
        {
            _applicationDbContext.Emails.Add(email);
            _applicationDbContext.SaveChanges();
        }
        public void EditOne(int id, Email email)
        {
            Email dbEmail = GetOne(id);

            dbEmail.Body = email.Body;
            _applicationDbContext.SaveChanges();
        }
        public void DeleteOne(int id)
        {
            Email dbEmail = GetOne(id);
            _applicationDbContext.Emails.Remove(dbEmail);
            _applicationDbContext.SaveChanges();
        }
    }
}
