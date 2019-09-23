using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Windows.UI.Xaml.Data;

namespace WpfCoreXamlIsland.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void myCustomListView_ChildChanged(object sender, EventArgs e)
        {
            // empty by design for now
        }

        private void UwpListViewNative_ChildChanged(object sender, EventArgs e)
        {
            // Example of getting binding working through code behind

            if (sender.GetType() == typeof(Microsoft.Toolkit.Wpf.UI.XamlHost.WindowsXamlHost))
            {
                var host = ((Microsoft.Toolkit.Wpf.UI.XamlHost.WindowsXamlHost)sender);

                if (host.Child != null &&
                    host.Child.GetType() == typeof(Windows.UI.Xaml.Controls.ListView))
                {
                    var CalView = ((Windows.UI.Xaml.Controls.ListView)host.Child);
                    CalView.DataContext = this.DataContext;
                    var myBinding = new Windows.UI.Xaml.Data.Binding()
                    {
                        Path = new Windows.UI.Xaml.PropertyPath("RandomColItems")
                    };

                    Windows.UI.Xaml.Data.BindingOperations.SetBinding(CalView,
                        Windows.UI.Xaml.Controls.ListView.ItemsSourceProperty, myBinding);
                }
            }
        }
        private void myCustomListView_ChildChanged(System.Object sender, System.EventArgs e)
        {

        }
    }
}
