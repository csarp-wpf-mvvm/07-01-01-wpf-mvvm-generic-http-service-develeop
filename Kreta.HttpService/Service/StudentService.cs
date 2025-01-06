using Kreta.HttpService.Service.Base;

namespace Kreta.Desktop.Service
{
    public class StudentService : BaseService, IStudentService
    {

        public StudentService() : base()
        {

        }
        public StudentService(IHttpClientFactory? httpClientFactory) : base(httpClientFactory)
        {
        }
    }
}
