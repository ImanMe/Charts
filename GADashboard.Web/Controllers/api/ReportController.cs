using GADashboard.Model.IRepository;
using System.Web.Http;

namespace GADashboard.Web.Controllers.api
{
    [AllowAnonymous]
    public class ReportController : ApiController
    {
        private readonly IRepository _repository;

        public ReportController(IRepository repository)
        {
            _repository = repository;
        }

        public IHttpActionResult Get()
        {
            //return Ok(_repository.GetTotalCount());

            var leadsSubmittedWithPaymentDriver = 310;
            var leadsSubmittedWithTradeDriver = 239;
            var leadsSubmittedWithFinanceDriver = 410;

            //leadsSubmittedWithPaymentDriver = context.GoogleAnalyticsData
            //    .Where(g => g.Source.EndsWith("paymentdriver"))
            //    .Count(g => g.PreqFlowComplete == "1" || g.BasicFlowComplete == "1" || g.FullFlowComplete == "1");

            //var totalLeads = leadsSubmittedWithPaymentDriver + leadsSubmittedWithTradeDriver +
            //               leadsSubmittedWithFinanceDriver;


            return Ok(new[] { leadsSubmittedWithPaymentDriver,
                leadsSubmittedWithTradeDriver, leadsSubmittedWithFinanceDriver});
        }
    }
}
