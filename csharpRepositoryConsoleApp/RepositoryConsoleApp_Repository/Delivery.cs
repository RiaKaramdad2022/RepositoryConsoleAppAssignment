using System;
// ! POCO
namespace RepositoryConsoleApp_Repository
{
    public class Delivery
    {
        public Delivery()
        {

        }

        public Delivery(string deliveryDate, string orderDate, StatusOrder orderStatus)
        {
            DeliveryDate = deliveryDate;
            OrderDate = orderDate;
            StatusOrder = orderStatus;
            ItemNum = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return $"Item number: {ItemNum}\nDelivery Date: {DeliveryDate}\nOrder Date: {OrderDate}";
        }

        public StatusOrder StatusOrder { get; set; }
        // The order date
        public string OrderDate { get; set; }

        // The delivery date
        public string DeliveryDate { get; set; }

        // The status of the order (Scheduled, EnRoute, Complete, or Canceled)
        // public string StatusOrder OrderStatus { get {
        //     switch (OrderStatus)
        //     {
        //         case StatusOrder.Scheduled:
        //             break;
        //         case StatusOrder.EnRoute:
        //             break;
        //         case StatusOrder.Complete:
        //             break;
        //         case StatusOrder.Canceled:
        //         default:
        //         break;
        //     }
        //     } }

        //The Item number
        public string ItemNum { get; private set; }

        // The item quantity
        public string ItemQuantity { get; set; }

        // The customer ID (you can assume every customer has an account with a unique ID number of some kind)
        public string customerID { get; set; }

    }

    public enum StatusOrder { Scheduled, EnRoute, Complete, Canceled }

}