using System;
namespace DesignTimeData
{
    //based on this blog post: https://blog.mzikmund.com/2017/07/checking-for-design-mode-in-xamarin-forms/
    public class DesignTimeHelper
    {
        public static bool IsInDesignMode = true;

        public static void SwitchOffDesignMode()
        {
            IsInDesignMode = false;
        }
    }
}
