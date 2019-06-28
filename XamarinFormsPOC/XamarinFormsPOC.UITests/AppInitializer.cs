using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace XamarinFormsPOC.UITests
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {

            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android.PreferIdeSettings().ApkFile("/Users/srinivasukatta/Projects/XamarinFormsPOC/XamarinFormsPOC.Android/bin/Debug/com.companyname.XamarinFormsPOC.apk")
                    .StartApp();
            }

            return ConfigureApp
                .iOS.PreferIdeSettings().InstalledApp("com.companyname.XamarinFormsPOC")
                .StartApp();
        }
    }
}
