using Prism.Ioc;
using System.Windows;
using WpfCoreXamlIsland.Views;

namespace WpfCoreXamlIsland
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }

        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }
    }
}
