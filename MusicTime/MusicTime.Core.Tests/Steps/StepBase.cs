using System;
using FluentValidation;
using Ninject;

namespace MusicTime.Core.Tests.Steps
{
    public class StepBase
    {
        private readonly StepContext _stepContext;

        protected StepBase(StepContext stepContext)
        {
            _stepContext = stepContext;
        }

        protected T Get<T>()
        {
            return _stepContext.ResolutionRoot.Get<T>();
        }

        protected void SetValidationException(ValidationException exception)
        {
            _stepContext.ValidationException = exception;
        }

        protected ValidationException GetValidationExeption()
        {
            return _stepContext.ValidationException;
        }
        protected void SetUnauthorizedAccessException(UnauthorizedAccessException unauthorizedAccessException)
        {
            _stepContext.UnauthorizedAccessException = unauthorizedAccessException;
        }
        protected UnauthorizedAccessException GetUnauthorizedAccessException()
        {
            return _stepContext.UnauthorizedAccessException;
        }

    }
}