using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;




namespace Rocket.Report.Results
{
    public class BadRequestResult : ErrorResult
    {
        public BadRequestResult(ValidationError error)
            : base(ResultStatusCode.BadRequest, error)
        {
        }

        public BadRequestResult(IEnumerable<ValidationError> errors)
            : base(ResultStatusCode.BadRequest, errors)
        {
        }
    }
}
