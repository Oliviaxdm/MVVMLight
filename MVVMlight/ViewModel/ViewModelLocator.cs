/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:MVVMlight"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;


namespace MVVMlight.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            ////if (ViewModelBase.IsInDesignModeStatic)
            ////{
            ////    // Create design time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DesignDataService>();
            ////}
            ////else
            ////{
            ////    // Create run time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DataService>();
            ////}
            //if (ViewModelBase.IsInDesignModeStatic)
            //{
                // 在Visual Studio中设计预览Xaml文件的时候，在这里注册会起作用;注册实例对象，注册到ioc容器中
                SimpleIoc.Default.Register<MainViewModel>();
                SimpleIoc.Default.Register<StudentViewModel>();
                SimpleIoc.Default.Register<Adddemo>();//}
            //else
            //{
            //    // 在运行时，在这里注册会起作用;
            //    SimpleIoc.Default.Register<MainViewModel>();

            //}
        }

        public MainViewModel Main
        {
            get
            {
                //通过容器获取实例对象 new Mainwindowl()
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public StudentViewModel Student
        {
            get
            {
                //通过容器获取实例对象 new Mainwindowl()
                return ServiceLocator.Current.GetInstance<StudentViewModel>();
            }
        }

        public Adddemo adddemo
        {
            get
            {
                //通过容器获取实例对象 new Mainwindowl()
                return ServiceLocator.Current.GetInstance<Adddemo>();
            }
        }


        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}