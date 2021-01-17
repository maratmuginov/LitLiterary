using LitLiterary.Clients.Wpf.ViewModels;
using LitLiterary.Clients.Wpf.Views;
using Microsoft.Extensions.DependencyInjection;

namespace LitLiterary.Clients.Wpf
{
    public partial class App
    {
        protected override void OnStartup(System.Windows.StartupEventArgs e)
        {
            var services = Bootstrapper.ConfigureServices();
            var mainWindow = new ShellView
            {
                DataContext = services.GetRequiredService<ShellViewModel>()
            };
            mainWindow.Show();
        }
    }
}
