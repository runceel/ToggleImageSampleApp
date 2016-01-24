using Prism.Windows.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace PickupMainPageImageApp.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private Visibility imageVisibility;

        public Visibility ImageVisibility
        {
            get { return this.imageVisibility; }
            set { this.SetProperty(ref this.imageVisibility, value); }
        }

        public void ToggleImageVisibility()
        {
            this.ImageVisibility = this.ImageVisibility == Visibility.Collapsed ? Visibility.Visible : Visibility.Collapsed;
        }
    }
}
