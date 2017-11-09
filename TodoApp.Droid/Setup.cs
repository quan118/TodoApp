using System;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Platform;
using TodoApp.Core;
using Android.Content;

namespace TodoApp.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }
    }
}
