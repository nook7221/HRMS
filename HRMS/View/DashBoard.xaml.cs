﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HRMS.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DashBoard : ContentPage
	{
		public DashBoard ()
		{
			InitializeComponent ();
		}


        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {

        }

        private async void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {

        }

        private async void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            var page = new TabbedPage
            {

                Children =
                    {
                        new OnLeave(),
                        new ListOfLeave(),
                       


                }
            };
            await Navigation.PushAsync(page);
        }
    }
}