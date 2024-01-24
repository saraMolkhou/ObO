using OptikBatikOrders.Entities;

namespace OptikBatikOrders
{
    public class DataContext 
    {
        public List<products> products = new List<products>();
        public List<orders> orders = new List<orders>();
        public List<customers> customers = new List<customers>();
        public DataContext()
        {
            products = new List<products>
            {
                 new products { Barcode="452698713", Price=458, ProdName="syd", Brand="gucci"},
                 new products {Barcode="478956213", Price=999, ProdName="otkgl", Brand="lemke-berlin"},
                 new products { Barcode="023541689", Price=326, ProdName="cfjtk", Brand="halperin"},
            };

            orders = new List<orders>
            {
                new orders { orderNum=130, Status="send", orderSum=450, orderDate=new DateTime(2022,12,20)},
                new orders { orderNum=255, Status="arrive", orderSum=200,  orderDate=new DateTime(2023,5,7)},
                new orders { orderNum=49, Status="send", orderSum=560,  orderDate=new DateTime(2024,01,01)},
            };

            customers = new List<customers>
            {
                 new customers { Id=1, Name="avraham", Age=50, City="netanya", HMO="clalit"},
                 new customers { Id=2, Name="yosi", Age=35, City="modiin", HMO="clalit"},
                 new customers { Id=3, Name="eden", Age=17, City="modiin-ilit", HMO="macabi"},
            };
                
        }
    }
}
