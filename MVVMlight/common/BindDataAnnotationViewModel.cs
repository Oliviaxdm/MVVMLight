using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;

namespace MVVMlight.common
{
    public class BindDataAnnotationViewModel : ViewModelBase, IDataErrorInfo
    {     

        public string this[string columnName] => throw new NotImplementedException();

        public string Error => throw new NotImplementedException();
    }
}
