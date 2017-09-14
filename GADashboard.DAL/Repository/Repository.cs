using GADashboard.Model.IRepository;
using System.Linq;
namespace GADashboard.DAL.Repository
{
    public class Repository : IRepository
    {
        private readonly AnalyticsContext _context;

        public Repository(AnalyticsContext context)
        {
            _context = context;
        }
        public long GetTotalCount()
        {
            return _context.GoogleAnalyticsData.Count();
        }
    }
}
