using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HRMS.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListOfLeave : ContentPage
	{
		public ListOfLeave ()
		{
			InitializeComponent ();

            ObservableCollection<Onleave> n = new ObservableCollection<Onleave>()
             {
                 {new Onleave(){RequesDay="01-04-2013", TypeLeave= "vacation leave", Day="01-10-2013 To 01-15-2013",CountDay = "6 Day",Status = "Disapproved" ,Note = "I fell tried, I want to relax"}},
                 {new Onleave(){RequesDay="04-07-2013", TypeLeave= "personal leave", Day="04-12-2013 To 04-13-2013",CountDay = "2 Day",Status = "approved" ,Note = "I must go outside "} },
                 {new Onleave(){RequesDay="05-10-2013", TypeLeave= "maternity leave", Day="05-11-2013 To 05-17-2013",CountDay = "7 Day",Status = "approved" ,Note = "my son is borning"} },
                 {new Onleave(){RequesDay="07-15-2013", TypeLeave= "study leave", Day="07-20-2013 To  07-25-2013",CountDay = "6 Day",Status = "approved" , Note = "I have study on Monday to Friday"} },
                 {new Onleave(){RequesDay="10-25-2013", TypeLeave= "personal leave", Day="10-25-2013 To 10-26-2013", CountDay = "2 Day",Status = "approved", Note = "My son is sick"} },
                 {new Onleave(){RequesDay="12-27-2013", TypeLeave= "vacation leave",Day="12-27-2013 To 12-29-2013",CountDay = "3 Day",Status = "approved", Note = "I will go to pattaya with my family"} },
             };
            ListLeave.ItemsSource = n;
        }

        private async void newslist_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            
        }
    }
}