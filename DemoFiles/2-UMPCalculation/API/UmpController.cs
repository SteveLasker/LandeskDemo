#region usings
using LandeskUMP.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
#endregion
namespace LandeskUMP.API
{
    public class UmpController : ApiController
    {
        public async Task<IEnumerable<Models.UmpScoreResult>> Get()
        {
            Business.UmpCalculator umpCalculator = new Business.UmpCalculator();
            IEnumerable<UmpScoreResult> umpResult = Enumerable.Empty<UmpScoreResult>();
            umpResult = await umpCalculator.GetUmpScores();

            return umpResult;
        }
    }
}
