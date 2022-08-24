﻿using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MoviesHome.EntityFrameworkCore;
using MoviesHome.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace MoviesHome.Web.Tests
{
    [DependsOn(
        typeof(MoviesHomeWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class MoviesHomeWebTestModule : AbpModule
    {
        public MoviesHomeWebTestModule(MoviesHomeEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MoviesHomeWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MoviesHomeWebMvcModule).Assembly);
        }
    }
}