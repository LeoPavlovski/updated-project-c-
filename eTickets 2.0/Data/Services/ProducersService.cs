using eTickets_2._0.Data.Base;
using eTickets_2._0.Models;

namespace eTickets_2._0.Data.Services
{
    public class ProducersService:EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base (context)
        {

        }
    }
}
