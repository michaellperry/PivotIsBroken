using Microsoft.Phone.Controls;
using System;
using System.Windows.Navigation;
using System.Windows.Threading;

namespace PivotIsBroken
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();

            DataContext = App.ViewModel;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            App.ViewModel.Pages.Add(new ViewModels.PageViewModel
                {
                    Title = "Old"
                }
                .WithItem("One")
                .WithItem("Two")
                .WithItem("Three"));

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(0.5);
            timer.Tick += delegate
            {
                App.ViewModel.Pages.RemoveAt(0);
                App.ViewModel.Pages.Add(new ViewModels.PageViewModel
                    {
                        Title = "New"
                    }
                    .WithItem("Four")
                    .WithItem("Five")
                    .WithItem("Six"));
                //App.ViewModel.Pages.Add(new ViewModels.PageViewModel());
                //ApplicationPivot.SelectedIndex = 1;
                //App.ViewModel.Pages.RemoveAt(1);
                timer.Stop();
            };
            timer.Start();
        }
    }
}