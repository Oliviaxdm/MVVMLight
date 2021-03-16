using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVMlight.ViewModel
{
   public  class Adddemo:ViewModelBase

    {
        public const string FirstNamePropertyName = "FirstName";

        private string _firstName = "";

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                Set(FirstNamePropertyName, ref _firstName, value);
            }
        }

        public const string ListtNamePropertyName = "ListName";

        private string _listName = "";

        public string ListName
        {
            get
            {
                return _listName;
            }
            set
            {
                Set(ListtNamePropertyName, ref _listName, value);
            }
        }

        public const string FulltNamePropertyName = "FullName";

        private string fullName = "";

        public string FullName
        {
            get
            {
                return fullName;
            }
            set
            {
                Set(FulltNamePropertyName, ref fullName, value);
            }
        }

        public const string UserInfoPropertyName = "UserInfo";

        private string _userModel = "";

        public string UserInfo
        {
            get
            {
                return _userModel;
            }
            set
            {
                Set(UserInfoPropertyName, ref _userModel, value);
            }
        }



        //给按钮绑定指令
        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand
                    ?? (addCommand = new RelayCommand(
                        () =>
                        //{}内为事件执行的方法
                        {
                            FullName = FirstName + '.' + ListName;
                        }
                        ));
            }

        }
    }
}
