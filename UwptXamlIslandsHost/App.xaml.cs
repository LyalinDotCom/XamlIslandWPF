using Microsoft.Toolkit.Win32.UI.XamlHost;

namespace UwptXamlIslandsHost
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App : XamlApplication
    {
        public App()
        {
            this.Initialize();
        }
    }
}
