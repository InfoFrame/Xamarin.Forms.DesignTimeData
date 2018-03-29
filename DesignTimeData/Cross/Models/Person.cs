using System;
using Xamarin.Forms;

namespace DesignTimeData.Models
{
    public class Person
    {
        public Person()
        {
            
        }
        public string Name
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
        public ImageSource Image
        {
            get;
            set;
        }
    }
}
