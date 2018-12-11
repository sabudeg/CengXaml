using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CengDepartment
{

    public partial class Altyapi : ContentPage
    {
        public List<Room> roomList { get; set; }

        public Altyapi()
        {
            InitializeComponent();
            
            roomList = new List<Room>
                {
                    new Room { Name = "Classroom-B1", Detail = "Capacity: 36", Image ="http://ceng.eskisehir.edu.tr/Documents/Class_B1.jpg" },
                    new Room { Name = "Classroom-B2", Detail = "Capacity: 15", Image = "http://ceng.eskisehir.edu.tr/Documents/Class_B2.jpg" },
                    new Room { Name = "Classroom-B3", Detail = "Capacity: 18", Image = "http://ceng.eskisehir.edu.tr/Documents/Class_B3.jpg"},
                    new Room { Name = "Classroom-B4 ", Detail= "Capacity: 24", Image ="http://ceng.eskisehir.edu.tr/Documents/Class_B4.jpg"  },
                    new Room { Name = "Classroom-B5" , Detail= "Capacity: 15", Image = "http://ceng.eskisehir.edu.tr/Documents/Class_B5.jpg" },
                    new Room { Name = "Classroom-B6" , Detail= "Capacity: 24", Image = "http://ceng.eskisehir.edu.tr/Documents/Class_B6.jpg" },
                    new Room { Name = "Classroom-B7" , Detail= "Capacity: 54", Image = "http://ceng.eskisehir.edu.tr/Documents/Class_B7.jpg" },
                    new Room { Name = "Lab-01", Detail= "61 PC" , Image = "http://ceng.eskisehir.edu.tr/Documents/Lab_PC1.jpg"  },
                    new Room { Name = "Lab-02", Detail= "24 iMac" , Image = "http://ceng.eskisehir.edu.tr/Documents/Lab_Mac1.jpg" }
                   
                };

            Room.ItemsSource = roomList;

        }

        Image grdImage = new Image();
       

       async void Room_ItemTapped(object sender, ItemTappedEventArgs e)
        
            {
                var selectedRoom = e.Item as Room;
                await Navigation.PushAsync(new AltyapiDetail(selectedRoom.Name, selectedRoom.Detail, selectedRoom.Image));

            }
        


            }
       }
  