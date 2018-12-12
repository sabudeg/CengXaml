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
        public List<Person> People { get; set; }

        public Kisiler()
        {
            InitializeComponent();

            People = new List<Person>
            {
                new Person { Name = "Dr.Öğr.Üyesi Ahmet ARSLAN", Email="Mail: aarslan2@anadolu.edu.tr", Phone="+90 (222) 321 35 50 / 6553"}
            };

            Person.ItemsSource = People;
        }

        public async void CallClicked(BindableObject sender, ItemTappedEventArgs e)
        {
            if (await this.DisplayAlert(
                    "Dial a Number",
                    "Would you like to call " + "+90(222) 321 35 50 " +  sender.BindingContext.ToString() + "?",
                    "Yes",
                    "No"))
            {
                var phoneDialer = CrossMessaging.Current.PhoneDialer;
                if (phoneDialer.CanMakePhoneCall)
                    phoneDialer.MakePhoneCall("+90(222) 321 35 50" +sender.BindingContext.ToString());

            }
        }

        public class Person
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public static object ItemsSource { get; internal set; }
        }
    }

}