using FormsControls.Base;
using Xamarin.Forms;

namespace DemoNavigation
{
    public partial class FadePage : ContentPage, IAnimationPage
    {
        public IPageAnimation PageAnimation { get; } = new FadePageAnimation
        {
            Duration = AnimationDuration.Long,
            Subtype = AnimationSubtype.FromLeft
        };

        public void OnAnimationStarted(bool isPopAnimation)
        {
            // Put your code here but leaving empty works just fine
        }

        public void OnAnimationFinished(bool isPopAnimation)
        {
            // Put your code here but leaving empty works just fine
        }

        public FadePage()
        {
            InitializeComponent();
        }
    }
}
