using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;

namespace Rocket.Report.Results
{
    public class ErrorBuilder 
    {
        private readonly ResourceManager _resourceManager;
        private readonly List<ValidationError> _errors;

        public IReadOnlyList<ValidationError> Errors => _errors;

        public bool HasErrors => _errors.Any();

        public ErrorBuilder()
        {
            _errors = new List<ValidationError>();

        }

        public ErrorBuilder(
            Type resourceType)
        {
            _errors = new List<ValidationError>();
            _resourceManager = new ResourceManager(resourceType);
        }

        public ErrorBuilder AddError(ValidationError error)
        {
            _errors.Add(error);
            return this;
        }

        public ErrorBuilder AddError(System.Enum code)
        {
            var error = GetError(code);

            _errors.Add(error);

            return this;
        }

        public ValidationError GetError(System.Enum @enum)
        {
            var errorMessage = _resourceManager.GetString(@enum.ToString());

            var err = new ValidationError(@enum.ToString(), errorMessage);

            return err;
        }

        public ValidationError GetError(System.Enum @enum, params string[] args)
        {
            var error = GetError(@enum);

            error.Message = string.Format(error.Message, args);

            return error;
        }

        public List<ValidationError> ToList()
        {
            return _errors;
        }
    }
}
