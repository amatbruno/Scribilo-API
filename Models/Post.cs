namespace Scribilo_API.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PublishDate { get; set; }
        public string? ModificationDate { get; set; }
        public string Body { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int PostImageRefId { get; set; }
        public PostImage PostImage { get; set; }
        public int SavedId { get; set; }
        public Saved Saved { get; set; }
    }
}
