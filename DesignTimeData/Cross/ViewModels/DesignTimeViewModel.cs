using System;
using System.Collections.Generic;
using DesignTimeData.Models;

namespace DesignTimeData.ViewModels
{
    public class DesignTimeViewModel : IViewModel
    {
        public DesignTimeViewModel()
        {
        }

        public string WelcomeText => "Designtime welcome text";

        public List<Person> Items => new List<Person>() { 
            new Person{Name="Test Person Girl", Image="girl.png", Description="I'm a beautiful girl."},
            new Person{Name="Test Person Boy", Image="boy.png", Description="My name is Bond, James Bond."},
        };
    }
}
