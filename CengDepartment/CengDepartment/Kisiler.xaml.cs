using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Messaging;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CengDepartment
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Kisiler : ContentPage
    {


        public Kisiler()
        {
            InitializeComponent();
        }

        public void CallClicked(object sender, EventArgs e)
        {
            var phoneDialer = CrossMessaging.Current.PhoneDialer;
            if (phoneDialer.CanMakePhoneCall)
            phoneDialer.MakePhoneCall(gsm.Text);
            //phoneDialer.MakePhoneCall("55555555");
        }
    }
}