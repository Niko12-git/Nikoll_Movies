using Nikoll_Movies.DAL.Dtos.Category;
using Nikoll_Movies.DAL.Dtos.Movie;
using Nikoll_Movies.DAL.Models;
using AutoMapper;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Nikoll_Movies.MoviesMapper
{
    public class Mappers : Profile
    {
        public Mappers()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryCreateUpdateDto>().ReverseMap();
            CreateMap<Movie, MovieDto>().ReverseMap();
            CreateMap<MovieCreateUpdateDto, Movie>();
        }
    }
}
