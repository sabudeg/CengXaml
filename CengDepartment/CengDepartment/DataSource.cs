using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CengDepartment
{
    public class DataSource
    {
        public string Name { get; set; }

        public string Category { get; set; }

        public string ImageFilename { get; set; }

        public DataSource(string name, string category, string imageFilename)
        {
            Name = name;
            Category = category;
            ImageFilename = imageFilename;
        }

        public static List<DataSource> GetList()
        {
            var l = new List<DataSource>();

            l.Add(new DataSource("Asparagus", "Vegetables", "Vegetables"));
            l.Add(new DataSource("Avocados", "Vegetables", "Vegetables"));
            l.Add(new DataSource("Beetroots", "Vegetables", "Vegetables"));
            l.Add(new DataSource("Capsicum", "Vegetables", "Vegetables"));
            l.Add(new DataSource("Broccoli", "Vegetables", "Vegetables"));
            l.Add(new DataSource("Brussel sprouts", "Vegetables", "Vegetables"));
            l.Add(new DataSource("Cabbage", "Vegetables", "Vegetables"));
            l.Add(new DataSource("Carrots", "Vegetables", "Vegetables"));
            return l;
        }

    }
}
