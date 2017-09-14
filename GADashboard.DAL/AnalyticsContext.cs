using GADashboard.Model.Models;
using System.Data.Entity;

namespace GADashboard.DAL
{
    public class AnalyticsContext : DbContext
    {
        public DbSet<AnalyticsData> GoogleAnalyticsData { get; set; }
        public AnalyticsContext()
            : base("DefaultConnection")
        {
        }
    }
}
