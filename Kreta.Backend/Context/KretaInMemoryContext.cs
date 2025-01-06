using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Context
{
    public class KretaInMemoryContext : KretaContext
    {
        public KretaInMemoryContext(DbContextOptions<KretaContext> options) : base(options)
        {
        }
    }
}
