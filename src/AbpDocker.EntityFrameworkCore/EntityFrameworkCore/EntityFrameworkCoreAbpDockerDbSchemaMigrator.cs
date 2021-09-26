﻿using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpDocker.Data;
using Volo.Abp.DependencyInjection;

namespace AbpDocker.EntityFrameworkCore
{
    public class EntityFrameworkCoreAbpDockerDbSchemaMigrator
        : IAbpDockerDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreAbpDockerDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the AbpDockerDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<AbpDockerDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
