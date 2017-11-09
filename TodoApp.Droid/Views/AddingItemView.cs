
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Droid.Views;
using TodoApp.Core.Services;
using TodoApp.Core.Models;
using TodoApp.Core.ViewModels;

namespace TodoApp.Droid.Views
{
    [Activity(Label = "AddingItemView")]
    public class AddingItemView : MvxActivity
    {
        protected AddingItemViewModel AssociatedViewModel
        {
            get { return ViewModel as AddingItemViewModel; }
        }

        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.AddingItemView);
        }
    }
}
