using System;
using FluentValidation;
using MusicTime.DI;
using Ninject.Syntax;

namespace MusicTime.Core.Tests.Steps
{
    public class StepContext
    {
        private IResolutionRoot _resolutionRoot;

        public IResolutionRoot ResolutionRoot
        {
            get { return _resolutionRoot ?? (_resolutionRoot = ContainerFactory.CreateKernel()); }
        }

        public ValidationException ValidationException { get; set; }
        public UnauthorizedAccessException UnauthorizedAccessException { get; set; }
    }
}