using MyApp.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MyApp
{
    //There are two distinct uses of mipmaps:
    //    1. For launcher icons when building density specific APKs.Some developers build separate APKs for every density,
    //       to keep the APK size down. However some launchers (shipped with some devices, or available on the Play Store) 
    //       use larger icon sizes than the standard 48dp.Launchers use getDrawableForDensity and scale down if needed, rather than up,
    //       so the icons are high quality.For example on an hdpi tablet the launcher might load the xhdpi icon. 
    //       By placing your launcher icon in the mipmap-xhdpi directory, it will not be stripped the way a drawable-xhdpi
    //       directory is when building an APK for hdpi devices. 
    //       If you're building a single APK for all devices, then this doesn't really matter as the launcher can access
    //       the drawable resources for the desired density.
    //    2.The actual mipmap API from 4.3. I haven't used this and am not familiar with it. It's not used by the Android Open Source Project launchers and I'm not aware of any other launcher using.

    //public class Application : Element

    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Gets or sets the root page of the application.
            //MainPage = new MainPage(); //When we don't want to use Navigation
            MainPage = new NavigationPage(new MainPage()); //When we want to use Navigation
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
