using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace MVVMlight.Model
{
  public   class StudentModel: ObservableObject

    {
        private int id;
        public int Id
        {
            get => id;
            set
            {
                id = value;
                RaisePropertyChanged(() => Id);
            }
        }

        private string  name;
        public string Name
        {
            get => name;
            set
            {
                name = value;
                RaisePropertyChanged(() => Name);
            }
        }

        private string fname;
        public string FName
        {
            get => fname;
            set
            {
                fname = value;
                RaisePropertyChanged(() => FName);
            }
        }


    }
}
