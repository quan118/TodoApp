using System;
using MvvmCross.Core.ViewModels;

namespace TodoApp.Core.ViewModels
{
    public class AddingItemViewModel : MvxViewModel
    {

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

        public AddingItemViewModel()
        {
        }
    }
}
