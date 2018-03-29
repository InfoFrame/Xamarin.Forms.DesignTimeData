using System;
using System.Collections.Generic;
using DesignTimeData.Models;

namespace DesignTimeData.ViewModels
{
    public interface IViewModel
    {
        string WelcomeText { get; }
        List<Person> Items { get; }
    }
}
