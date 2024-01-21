using OptikBatikOrders.Entities;

namespace OptikBatikOrders
{
    public interface IDataContext
    {
         List<products> products { get; set; }
         List<orders> orders { get; set; }
        List<customers> customers { get; set; }
    }
}
