using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MyApp.Pages
{
	public class Page1 : ContentPage
	{
		public Page1 ()
		{
            Button button = new Button { Text = "RelativePage", Margin = new Thickness(20) };
            button.Clicked += async (sender, e) => await Navigation.PushAsync(new RelativePage());

            Content = new StackLayout {
				Children = {
					new Label { Text = "Welcome to Xamarin.Forms!" },
                    button
                }
			};
		}
    }
}