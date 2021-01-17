using System;
using LitLiterary.Clients.Wpf.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace LitLiterary.Clients.Wpf
{
    public static class Bootstrapper
    {
        public static IServiceProvider ConfigureServices()
        {
            return new ServiceCollection()
                .AddSingleton<ShellViewModel>()
                .BuildServiceProvider();
        }
    }
}
