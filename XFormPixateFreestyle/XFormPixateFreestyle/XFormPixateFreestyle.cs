using System;

using Xamarin.Forms;

namespace XFormPixateFreestyle
{
	public class App : Application
	{
		public App ()
		{
			var button = new Button {
				Text = "Button 1"
			};
			button.StyleId = "buttondemo";

			var button2 = new Button {
				Text = "Button 2"
			};
			button2.ClassId = "normalButton";
			// The root page of your application
			MainPage = new ContentPage {
				BackgroundColor = Color.White,
				Content = new StackLayout {
					Padding = 20,
					VerticalOptions = LayoutOptions.Center,
					Children = {
						button,
						button2,
					}
				}
			};
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

