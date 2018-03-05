using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HRMS.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CreatUserScreen : ContentPage
	{
        public string group { get; set; }
		public CreatUserScreen ()
		{
			InitializeComponent ();

            Group.Items.Add("Admin");
            Group.Items.Add("User");

        }


        private async void Button_Clicked(object sender, EventArgs e)
        {
           


        }


    }
}