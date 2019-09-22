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

        private void myCalendar_ChildChanged(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(Microsoft.Toolkit.Wpf.UI.XamlHost.WindowsXamlHost))
            {
                var host = ((Microsoft.Toolkit.Wpf.UI.XamlHost.WindowsXamlHost)sender);

                if (host.Child.GetType() == typeof(Windows.UI.Xaml.Controls.ListView))
                {
                    var CalView = ((Windows.UI.Xaml.Controls.ListView)host.Child);

                    CalView.Items.Add(new string("test"));
                    CalView.Items.Add(new string("test"));
                    CalView.Items.Add(new string("test"));
                    CalView.Items.Add(new string("test"));
                }
            }

        }
    }
}
