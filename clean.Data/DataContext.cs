using clean.core.Entities;
using Microsoft.EntityFrameworkCore;

namespace clean.Data
{
    public class DataContext: DbContext
    {
        public DbSet<customer> Customers { get; set; }
        public DbSet<product> Products { get; set; }
        public DbSet<order> Orders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=sample_db");

        }


        //public List<customer> Customers { get; set; }
        //public List<product> Products { get; set; }
        //public List<order> Orders { get; set; }

        //public DataContext()
        //{
        //    Customers = new List<customer>
        //    {
        //        new customer { Id=1, Name="avraham", Age=50, City="netanya", HMO="clalit"},
        //         new customer { Id=2, Name="yosi", Age=35, City="modiin", HMO="clalit"},
        //         new customer { Id=3, Name="eden", Age=17, City="modiin-ilit", HMO="macabi"},
        //    };
        //    Products = new List<product>
        //    {
        //         new product { Barcode="452698713", Price=458, ProdName="syd", Brand="gucci"},
        //         new product {Barcode="478956213", Price=999, ProdName="otkgl", Brand="lemke-berlin"},
        //         new product { Barcode="023541689", Price=326, ProdName="cfjtk", Brand="halperin"},
        //    };
        //    Orders = new List<order>
        //    {
        //            new order { orderNum=130, Status="send", orderSum=450, orderDate=new DateTime(2022,12,20)},
        //            new order { orderNum=255, Status="arrive", orderSum=200,  orderDate=new DateTime(2023,5,7)},
        //            new order { orderNum=49, Status="send", orderSum=560,  orderDate=new DateTime(2024,01,01)},
        //    };

    }
}
