using ProjectCards.Pages;
using ProjectCards.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ProjectCards
{
    public class App : Application
    {
        public App()
        {
            //// The root page of your application
            //MainPage = new ContentPage
            //{
            //    Content = new StackLayout
            //    {
            //        VerticalOptions = LayoutOptions.Center,
            //        Children = {
            //             new Label {
            //                 HorizontalTextAlignment = TextAlignment.Center,
            //                 Text = "Welcome to Project Cards!"
            //             }
            //         }
            //    }
            //};


            // create a new NavigationPage, with a new AcquaintanceListPage set as the Root
            var navPage =
                new NavigationPage(
                    new HomePage()
                    {
                        BindingContext = new HomeViewModel(),
                        Title = "Home"
                    })
                {
                    BarBackgroundColor = Color.FromHex("547799")
                };

            navPage.BarTextColor = Color.White;

            // set the MainPage of the app to the navPage
            MainPage = navPage;
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
