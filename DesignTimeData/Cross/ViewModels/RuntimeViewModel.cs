using System;
using System.Collections.Generic;
using DesignTimeData.Models;

namespace DesignTimeData.ViewModels
{
    public class RuntimeViewModel : IViewModel
    {
        public RuntimeViewModel()
        {
        }
        public string WelcomeText => "Runtime welcome text";

        public List<Person> Items => throw new NotImplementedException();
    }
}
