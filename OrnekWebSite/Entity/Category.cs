using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrnekWebSite.Entity
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descrition { get; set; }
        public List<Product> Products { get; set; }
    }
}