namespace Scribilo_API.Models
{
    public class PostImage
    {
        public int Id { get; set; }

        //INVESTIGAR CAMPO PARA ADJUNTAR IMAGENES

        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
