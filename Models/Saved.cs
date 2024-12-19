namespace Scribilo_API.Models
{
    public class Saved
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
