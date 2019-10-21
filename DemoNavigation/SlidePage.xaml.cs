using System;
using System.Collections.Generic;
using FormsControls.Base;
using Xamarin.Forms;

namespace DemoNavigation
{
    public partial class SlidePage : ContentPage, IAnimationPage
    {
        public IPageAnimation PageAnimation { get; } = new SlidePageAnimation
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

        public SlidePage()
        {
            InitializeComponent();
        }
    }
}
