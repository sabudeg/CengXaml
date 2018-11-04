using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CengDepartment
{
    public partial class Altyapi : ContentPage
    {
        public Altyapi()
        {
            InitializeComponent();

            listView.ItemsSource = DataSource.GetList();
        }
    }
}