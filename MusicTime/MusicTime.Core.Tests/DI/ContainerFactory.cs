﻿using MusicTime.Core.Abstract.Storage;
using MusicTime.Storage;
using Ninject;
using Ninject.Syntax;

namespace MusicTime.Core.Tests.DI
{
    internal class ContainerFactory
    {
        public static IResolutionRoot CreateKernel()
        {
            var kernel = new StandardKernel();
            
            kernel.Bind(typeof(IRepository<>)).To(typeof(Repository<>));

            kernel.Load<CommanHandlerModule>();

            kernel.Load<ValidatorModule>();

            kernel.Load<StorageModule>();

            kernel.Load<QueryModule>();

            return kernel;
        }
    }
}