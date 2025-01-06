using Kreta.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kreta.Desktop.Service
{
    public interface IStudentService
    {
        public Task<List<Student>> SelectAllStudent();
    }
}
