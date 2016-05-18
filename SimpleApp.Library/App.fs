namespace SimpleApp.Library

open Xamarin.Forms

type App() = 
    inherit Application(MainPage = new ContentPage(Content = new Label(Text = "Hello world!")))
