namespace Scribilo_API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? Country { get; set; }
        public string? Linkedin { get; set; }
        public string? Biography { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
