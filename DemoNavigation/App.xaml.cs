using FormsControls.Base;
using Xamarin.Forms;

namespace DemoNavigation
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AnimationNavigationPage(new MainPage());
        }
    }
}
