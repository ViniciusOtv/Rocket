using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Rocket.Report.Results;

namespace Rocket.Report.Services
{
    public abstract class ServiceBase
    {
        protected readonly ErrorBuilder ErrorBuilder;

        protected ServiceBase(ErrorBuilder builder)
        {
            ErrorBuilder = builder;
        }
        protected virtual bool Validate<TModel>(TModel model)
        {
            var context = new ValidationContext(model, null, null);
            var results = new List<ValidationResult>();

            if (Validator.TryValidateObject(model, context, results, true))
            {
                return true;
            }

            foreach (var ValidationResult in results)
            {
                ErrorBuilder.AddError(new ValidationError(ValidationResult.MemberNames.First(), ValidationResult.ErrorMessage));
            }

            return false;
        }

        protected OkResult Ok()
        {
            return new OkResult();
        }

        protected MethodResult BadRequest(System.Enum error)
        {
            return new BadRequestResult(ErrorBuilder.GetError(error));
        }

        protected MethodResult BadRequest(ValidationError error)
        {
            return new BadRequestResult(error);
        }

        protected MethodResult BadRequest(IEnumerable<ValidationError> errorList)
        {
            return new BadRequestResult(errorList);
        }
    }
}