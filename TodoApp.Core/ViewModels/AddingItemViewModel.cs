using System;
using System.Windows.Input;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using TodoApp.Core.Services;
using TodoApp.Core.Models;

namespace TodoApp.Core.ViewModels
{
    public class AddingItemViewModel : MvxViewModel
    {
        private IDataSource _dataSource;

        private String _title;
        public String Title
        {
            get
            {
                return _title;
            }

            set
            {
                _title = value;
                RaisePropertyChanged(() => Title);
            }
        }

        private String _description;
        public String Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                RaisePropertyChanged(() => Description);
            }
        }

        public ICommand SaveItemCommand
        {
            get
            {
                return new MvxCommand(() =>
                {
                    if (Title != null && Title.Trim().Length > 0)
                    {
                        _dataSource.AddItem(new Item(Title, Description));
                    }
                    Close(this); // go back to previous activity
                });
            }
        }

        public AddingItemViewModel()
        {
            _dataSource = Mvx.Resolve<IDataSource>();
        }
    }
}
