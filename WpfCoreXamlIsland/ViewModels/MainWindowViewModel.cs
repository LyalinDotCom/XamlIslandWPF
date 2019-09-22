using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace WpfCoreXamlIsland.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private ObservableCollection<string> _randomCol = new ObservableCollection<string>();
        public ObservableCollection<string> RandomColItems
        {
            get { return _randomCol; }
            set { SetProperty(ref _randomCol, value); }
        }

        public MainWindowViewModel()
        {
            _randomCol.Add("test");
        }
    }
}
