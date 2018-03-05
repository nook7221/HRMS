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
	public partial class OnLeave : ContentPage
	{
		public OnLeave ()
		{
			InitializeComponent ();
            subject.Items.Add("vacation leave");//ลาพักร้อน
            subject.Items.Add("personal leave");//ลากิจ
            subject.Items.Add("maternity leave");//ลาคลอด
            subject.Items.Add("family responsibility leave");//การลาหยุดเพื่อดูแลครอบครัว
            subject.Items.Add("bereavement leave");//ลาหยุดเมื่อครอบครัวหรือญาติใกล้ชิดเสียชีวิต
            subject.Items.Add("study leave");// ลาไปเรียนต่อ
            subject.Items.Add("marriage leave");//ลาไปแต่งงาน
            subject.Items.Add("paternity leave");//สิทธิของบิดาในการลาเพื่อดูแลบุตร 
            subject.Items.Add("ordination leave");//ลาบวช
            subject.Items.Add("military service leave");//ลารับราชการทหาร
        }

        public async void Click_submit(object sender, EventArgs e)
        {

        }
    }
}