using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KE3.DiSample
{
    public static class IHostBuilderExtension
    {
        public static IHostBuilder
        UseAutofacServiceProviderFactory(
        this IHostBuilder hostbuilder)
        {
            hostbuilder.UseServiceProviderFactory<ContainerBuilder>(
            new AutofacServiceProviderFactory());
            return hostbuilder;
        }
    }
}
