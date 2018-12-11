using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CengDepartment
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AltyapiDetail : ContentPage
    {
        public AltyapiDetail(string Name, string Detail, string Image)
        {
            InitializeComponent();

            RoomName.Text = Name;
            RoomDetail.Text = Detail;
            RoomImage.Source = new UriImageSource()
            {
                Uri = new Uri(Image)
            };
        }
    }
}