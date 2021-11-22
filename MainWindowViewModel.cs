using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MweMahAppsRangeSliderBug
{
    public class MainWindowViewModel : ViewModelBase
    {
        private Visibility __exampleSliderVisible = Visibility.Visible;
        public Visibility ExampleSliderVisible
        {
            get { return __exampleSliderVisible; }
            set { __exampleSliderVisible = value; }
        }

        public MainWindowViewModel()
        {
            this.ExampleChangeVisibility = new SimpleCommand(
                o => true,    
                x => ToggleVisibility()
                );
        }

        public ICommand ExampleChangeVisibility { get; }

        public void ToggleVisibility()
        {
            if(ExampleSliderVisible == Visibility.Visible)
            {
                ExampleSliderVisible = Visibility.Collapsed;
            }
            else
            {
                ExampleSliderVisible = Visibility.Visible;
            }

            this.OnPropertyChanged(nameof(this.ExampleSliderVisible));
        }
    }
}
