using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlTemplateTest.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        
        public string HeaderText { get; set; }
        public string MyContent { get; set; }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            HeaderText = "Hello";
            MyContent = "Content";
        }
        
    }
}
