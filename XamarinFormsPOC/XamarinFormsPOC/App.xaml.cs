using System;
using DLToolkit.Forms.Controls;
using FreshMvvm;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsPOC.PageModels;
using XamarinFormsPOC.Services;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinFormsPOC
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //flowlistviewIntialization
            FlowListView.Init();

            //IOC Registrations            
            FreshIOC.Container.Register<ISpeciesApi, SpeciesService>();

            MainPage = new FreshNavigationContainer(FreshPageModelResolver.ResolvePageModel<SpeciesListPageModel>())
            {
                BarBackgroundColor = Color.Teal,
                BarTextColor = Color.White
            };



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
