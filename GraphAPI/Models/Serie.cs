namespace GraphAPI.Models
{

    public class Serie{

        public string? Name {get; set;}
        public DateTime ReleaseDate{get; set;} 
        public List <Plataforma>? Platforms{get; set;}

    }

}