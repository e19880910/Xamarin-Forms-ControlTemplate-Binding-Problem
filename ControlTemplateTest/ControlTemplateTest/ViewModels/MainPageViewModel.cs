using Prism.Navigation;

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
