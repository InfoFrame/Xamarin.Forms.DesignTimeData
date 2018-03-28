using System;
namespace DesignTimeData.ViewModels
{
    public class RuntimeViewModel : IViewModel
    {
        public RuntimeViewModel()
        {
        }
        public string WelcomeText => "Runtime welcome text";
    }
}
