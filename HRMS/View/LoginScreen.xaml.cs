using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMS.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HRMS.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginScreen : ContentPage
	{
		public LoginScreen ()
		{
			InitializeComponent ();
		}

        public async  void btn_ClickSiginEx(object sender, EventArgs e)
        {
            /*if (MainUser.Text != "admin1234" )
            {
                DisplayAlert("Cannot Login", "Invalid username ", "OK");
                MainUser.Focus();

            }

            else if(MainPassword.Text != "admin1234")
            {
                DisplayAlert("Cannot Login", "Invalid password", "OK");
                MainPassword.Focus();
            }*/
           // else
            //{
                var nav = new NavigationPage(new DashBoard()) { BarBackgroundColor = Color.FromHex("#82ada9"), BarTextColor = Color.White };
                await App.Current.MainPage.Navigation.PushModalAsync(nav);
           // }
        }


        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var nav = new NavigationPage(new RegisterPage()) { BarBackgroundColor = Color.FromHex("#82ada9"), BarTextColor = Color.White };
            await Navigation.PushModalAsync(nav);
        }

        }
}