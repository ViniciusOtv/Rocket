

namespace Rocket.Report.Results
{
    public class OkResult : MethodResult
    {
        public OkResult()
            : base(ResultStatusCode.OK)
        {
        }
    }

    public class OkResult<TContent> : MethodResult<TContent>
    {
        public OkResult(TContent content)
            : base(content, ResultStatusCode.OK)
        {
        }
    }
}
