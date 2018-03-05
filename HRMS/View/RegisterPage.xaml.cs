using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMS.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HRMS.Model;

namespace HRMS.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]

    
	public partial class RegisterPage : ContentPage
	{
        UserAccount dummy = new UserAccount();
		public RegisterPage ()
		{
			InitializeComponent ();



            dummy.user = ("admin1234");
            dummy.pass = ("admin1234");
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(username.Text))
            {
                DisplayAlert("Cannot Create", "Plase enter username", "OK");
                username.Focus();
            }
            else if (string.IsNullOrWhiteSpace(pass.Text))
            {
                DisplayAlert("Cannot Create", "Plase enter password", "OK");
                pass.Focus();
            }
            else if (confirmpass.Text != pass.Text)
            {
                DisplayAlert("Cannot Create", "The password does not match ", "OK");
                pass.Focus();
            }
            else if (string.IsNullOrWhiteSpace(confirmpass.Text))
            {
                DisplayAlert("Cannot Create", "Plase confirm password", "OK");
                confirmpass.Focus();
            }
            else if (string.IsNullOrWhiteSpace(fname.Text))
            {
                DisplayAlert("Cannot Create", "Plase enter your firstname", "OK");
                fname.Focus();
            }
            else if (string.IsNullOrWhiteSpace(lname.Text))
            {
                DisplayAlert("Cannot Create", "Plase enter your lastname", "OK");
                lname.Focus();
            }
            else if (string.IsNullOrWhiteSpace(tel.Text))
            {
                DisplayAlert("Cannot Create", "Plase enter your phonenumber", "OK");
                tel.Focus();
            }
            else if (string.IsNullOrWhiteSpace(email.Text))
            {
                DisplayAlert("Cannot Create", "Plase enter your E-mail", "OK");
                email.Focus();
            }
            else if(username.Text == dummy.user)
            {
                DisplayAlert("Cannot Create", "Username is already used", "OK");
                username.Focus();
            }

            else
            {
                var nav = new LoginScreen();
                await Navigation.PushModalAsync(nav);
            }

        }

    }
}