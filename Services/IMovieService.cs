using MvcMovie.Models;
using System.Threading.Tasks;

namespace MvcMovie.Services
{
    public interface IMovieService
    {
        Task Create(Movie model);
    }
}