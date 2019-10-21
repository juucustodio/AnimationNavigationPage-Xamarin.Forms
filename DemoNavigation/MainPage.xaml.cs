using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoNavigation
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void GoSlidePageFromLeft(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SlidePage());
        }

        private async void GoFadePageFromLeft(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FadePage());
        }

        private async void GoRollPageFromLeft(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RollPage());
        }

        private async void GoRotatePageFromLeft(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RotatePage());
        }

        private async void GoPushPageFromLeft(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PushPage());
        }    
    }
}
