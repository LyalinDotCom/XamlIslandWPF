using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace WpfCoreXamlIsland.ViewModel
{
    public class MainPageViewModel : BindableBase
    {
        private ObservableCollection<string> _randomCol = new ObservableCollection<string>();
        public ObservableCollection<string> RandomColItems
        {
            get { return _randomCol; }
            set { SetProperty(ref _randomCol, value); }
        }

        public MainPageViewModel()
        {
            _randomCol.Add("test");
        }
    }
}
