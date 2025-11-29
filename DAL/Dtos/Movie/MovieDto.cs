using System.ComponentModel.DataAnnotations;

namespace Nikoll_Movies.DAL.Dtos.Movie
{
    public class MovieDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public string Classification { get; set; }
        public string? Description { get; set; }
        public string? Director { get; set; }
        public int? ReleaseYear { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
