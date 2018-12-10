using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace NipponDemo.UITests
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp.Android.ApkFile("../../../NipponDemo.Android/bin/Debug/com.nous.mobility.NipponDemo.apk").StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}