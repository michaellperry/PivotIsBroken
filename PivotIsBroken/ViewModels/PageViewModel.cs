using System.Collections.ObjectModel;
using System.ComponentModel;

namespace PivotIsBroken.ViewModels
{
    public class PageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _title;
        private ObservableCollection<ItemViewModel> _items =
            new ObservableCollection<ItemViewModel>();

        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Title"));
            }
        }

        public ObservableCollection<ItemViewModel> Items
        {
            get { return _items; }
        }

        public PageViewModel WithItem(string text)
        {
            _items.Add(new ItemViewModel { Text = text });
            return this;
        }
    }
}
