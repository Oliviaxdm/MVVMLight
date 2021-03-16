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
   public  class StudentViewModel:ViewModelBase
    {
        public StudentViewModel()
        {
            if (IsInDesignMode)
            {
                //设计时数据
                StudentModel = new Model.StudentModel() { Id = 1, Name = "zhansgan" };
            }
            else
            {
                //从数据库获取
                StudentModel = new Model.StudentModel() { Id = 4, Name = "lisi" };
            }
        }
        public Model.StudentModel StudentModel { get; set; }

        //给按钮绑定指令
        private RelayCommand addDoneCommand;
        public RelayCommand AddDoneCommand
        {
            get
            {
                return addDoneCommand
                    ?? (addDoneCommand = new RelayCommand(
                        () =>
                        //{}内为事件执行的方法
                        {

                            StudentModel.FName = StudentModel.Id.ToString()+ '.' + StudentModel.Name;
                        }
                        ));
            }

        }

    }
}
