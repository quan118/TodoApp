using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Input;
using System.Collections.ObjectModel;
using MvvmCross.Core.ViewModels;
using TodoApp.Core.Models;
using TodoApp.Core.Services;

namespace TodoApp.Core.ViewModels
{
    public class ItemListViewModel : MvxViewModel
    {
        private IDataSource _dataSource;

        private ObservableCollection<Item> _items;
        public ObservableCollection<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
                RaisePropertyChanged(() => Items);
            }
        }

        public ICommand AddItemCommand
        {
            get
            {
                return new MvxCommand(() => ShowViewModel<AddingItemViewModel>());
            }
        }

        public ICommand ClearDoneItems
        {
            get
            {
                return new MvxCommand(() =>
                {
                    _dataSource.ClearDoneItems();
                    Refresh();
                });
            }
        }

        public ItemListViewModel(IDataSource dataSource)
        {
            _dataSource = dataSource;    
        }

        public override void ViewAppeared()
        {
            Refresh();
            base.ViewAppeared();
        }

        protected void Refresh()
        {
            Items = new ObservableCollection<Item>(_dataSource.Items);
        }
    }
}
