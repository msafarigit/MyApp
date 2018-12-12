﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyApp.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AbsolutePage : ContentPage
	{
		public AbsolutePage ()
		{
			InitializeComponent ();
		}

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1(), true);
        }
    }
}