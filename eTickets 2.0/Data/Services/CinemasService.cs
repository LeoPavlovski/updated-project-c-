using eTickets_2._0.Data.Base;
using eTickets_2._0.Models;

namespace eTickets_2._0.Data.Services
{
    public class CinemasService:EntityBaseRepository<Cinema>,ICinemasService
    {
        public CinemasService(AppDbContext context): base(context)
        {

        }
    }
}
