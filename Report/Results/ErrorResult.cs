using System.Collections.Generic;
using Rocket.Report.Results;

namespace Rocket.Report.Results
{
    public class ErrorResult : MethodResult
    {
        public IEnumerable<ValidationError> Errors { get; set; }

        public ErrorResult(ResultStatusCode statusCode, ValidationError error) : base(statusCode)
        {
            Errors = new[] { error };
        }

        public ErrorResult(ResultStatusCode statusCode, IEnumerable<ValidationError> errors) : base(statusCode)
        {
            Errors = errors;
        }
    }
}
