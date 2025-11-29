using Nikoll_Movies.DAL.Models;

namespace Nikoll_Movies.Repository.IRepository
{
    public interface IMovieRepository
    {
        Task<ICollection<Movie>> GetMoviesAsync(); //Me retorna una lista de películas
        Task<Movie> GetMovieAsync(int id); //Me retorna una película en específico
        Task<bool> MovieExistsByIdAsync(int id); //Verifica si una película existe por id
        Task<bool> MovieExistsByNameAsync(string name); //Verifica si una película existe por nombre
        Task<bool> CreateMovieAsync(Movie movie); //Crea una nueva película
        Task<bool> UpdateMovieAsync(Movie movie); //Actualiza una película
        Task<bool> DeleteMovieAsync(int id); //Elimina una película buscando por id
    }
}
