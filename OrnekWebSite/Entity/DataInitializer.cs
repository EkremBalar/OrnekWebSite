using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrnekWebSite.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {

            var kategoriler = new List<Category>()
            {
                new Category() {Name="KAMERA",Descrition="KAMERA ÜRÜNLERİ"},
                new Category() {Name="TELEFON",Descrition="TELEFON ÜRÜNLERİ"},
                new Category() {Name="TABLET",Descrition="TABLET ÜRÜNLERİ"},

            };
            foreach (var kategori in kategoriler)
            {
                context.Categoris.Add(kategori);

            };
            context.SaveChanges();
            var urunler = new List<Product>()
            {
                new Product() {Name=" Canon Kamera",Descriptions="Kamera", Price=2500,Stock=150,IsHome=true,IsApproved=true,IsFeatured=false,Slider=true,CategoryId=1,Image="1.jpg"},

                 new Product() {Name=" Iphone 13 ",Descriptions="Telefon", Price=15500,Stock=100,IsHome=true,IsApproved=true,IsFeatured=true,Slider=true,CategoryId=2,Image="2.jpg"},

                  new Product() {Name="Lenovo Tablet",Descriptions="Tablet ", Price=1200,Stock=50,IsHome=false,IsApproved=true,IsFeatured=true,Slider=false,CategoryId=3,Image="3.jpg"},

                  new Product() {Name="Samsung S20 ",Descriptions="Telefon", Price=15000,Stock=120,IsHome=true,IsApproved=true,IsFeatured=true,Slider=true,CategoryId=2,Image="4.jpg"},

                   
            };
            foreach (var urun in urunler)
            {
                context.Products.Add(urun);

            }
            context.SaveChanges();
            base.Seed(context);

       } 
    }           


}
   
