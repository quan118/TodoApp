using System;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using TodoApp.Core.ViewModels;
using TodoApp.Core.Services;

namespace TodoApp.Core
{
    public class App : MvxApplication
    {
        public App()
        {
            Mvx.RegisterSingleton<IDataSource>(new LocalDataSource());
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<ItemListViewModel>());
        }
    }
}
