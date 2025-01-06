using Kreta.Backend.Repos.Base;
using Kreta.Shared.Models;

namespace Kreta.Backend.Repos
{
    public interface IStudentRepo : IBaseRepo<Student>
    {
        public Task<Student> GetStudentByNameAsync(string firstName, string lastName);
    }
}
