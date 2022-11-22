namespace WebAppREST_API.Models
{
    public class Email
    {
        public int? Id { get; set; }
        public string? Subject { get; set; }
        public string? Body { get; set; }
        public int? FromId { get; set; }
        public Person? From { get; set; }
        public string? ToIds { get; set; }
        public List<Person>? To { get; set; }
    }
}
