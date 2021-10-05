using MarvelClient;
using MarvelClient.Utils;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarvelClientShould
{
    public class BaseUnitTestClass
    {
        protected DependencyResolverHelper _serviceProvider;

        public BaseUnitTestClass()
        {
            var webHost = WebHost.CreateDefaultBuilder()
                .UseStartup<Startup>()
                .Build();
            _serviceProvider = new DependencyResolverHelper(webHost);
        }
    }
}
