using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeysGallery.Models
{
    public class Monkey
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
        public string Image { get; set; }
        public int Population { get; set; }

        public Monkey(string name, string location, string details, string image, int population)
        {
            Name = name;
            Location = location;
            Details = details;
            Image = image;
            Population = population;
        }

        public Monkey()
        {
           
        }



    }
}
