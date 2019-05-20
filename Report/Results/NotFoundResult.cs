
namespace Rocket.Report.Results
{
    public class NotFoundResult : MethodResult
    {
        public NotFoundResult()
            : base(ResultStatusCode.NotFound)
        {
        }
    }
}
