using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrnekWebSite.Entity
{
    public class Product
    {
        public int Id { get;   set; }

        public string Name { get; set; }
        public string Descriptions { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public int   Stock { get; set; }
        public bool Slider { get; set; }
        public bool IsHome { get; set; }  //anasayfada
        public bool IsFeatured { get; set; } //popüler
        public bool IsApproved { get; set; } //onaylı

        public int CategoryId { get; set; }
         public Category Category { get; set; }

    }
}