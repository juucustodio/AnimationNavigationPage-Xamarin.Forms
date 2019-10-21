using FormsControls.Base;
using Xamarin.Forms;

namespace DemoNavigation
{
    public partial class RollPage : ContentPage, IAnimationPage
    {
        public IPageAnimation PageAnimation { get; } = new RollPageAnimation
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
    
        public RollPage()
        {
            InitializeComponent();
        }
    }
}
