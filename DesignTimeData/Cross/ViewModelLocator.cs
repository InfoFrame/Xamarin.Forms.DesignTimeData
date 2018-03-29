using System;
using DesignTimeData.ViewModels;
namespace DesignTimeData
{
    public static class ViewModelLocator
    {
        public static IViewModel MainViewModel
        {
            get { return GetViewModel(); }
        }

        private static IViewModel GetViewModel()
        {
            return DesignTimeHelper.IsInDesignMode ? new DesignTimeViewModel() as IViewModel : new RuntimeViewModel() as IViewModel;
        }
    }
}
