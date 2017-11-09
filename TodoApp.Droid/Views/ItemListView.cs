
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
using MvvmCross.Platform;
using TodoApp.Core.Services;
using TodoApp.Core.Models;
using TodoApp.Core.ViewModels;

namespace TodoApp.Droid.Views
{
    [Activity(Label = "ItemListView")]
    public class ItemListView : MvxActivity
    {
        protected ItemListViewModel AssociatedViewModel
        {
            get { return ViewModel as ItemListViewModel; }
        }

        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.ItemListView);
            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = "To-do App";
        }
    }
}
