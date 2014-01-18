using System.Collections.ObjectModel;
using System.ComponentModel;

namespace PivotIsBroken.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<PageViewModel> _pages =
            new ObservableCollection<PageViewModel>();

        public ObservableCollection<PageViewModel> Pages
        {
            get { return _pages; }
        }
    }
}