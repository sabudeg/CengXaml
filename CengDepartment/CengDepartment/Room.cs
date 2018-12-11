using System;
using System.Collections.Generic;
using System.Text;

namespace CengDepartment
{
    public class Room

    {
        public string Name { get; set; }
        public string Detail { get; set; }
        public string Image { get; set; }
        public static object ItemsSource { get; internal set; }

        //public Room(string name, string detail, string ımage)
        //{
        //    Name = name;
        //    Detail = detail;
        //    Image = ımage;
        //}
    }
}
