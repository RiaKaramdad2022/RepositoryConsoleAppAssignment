using System.Collections.Generic;
// ! Repository (with CRUD Method)
namespace RepositoryConsoleApp_Repository
{
    public class DeliveryRepository
    {
        public List<Delivery> database = new List<Delivery>();

        public void DatabaseInit()
        {
            Delivery delivery1 = new Delivery("Feb-01-2022", "Jan-29-2022", StatusOrder.EnRoute);
            database.Add(delivery1);
        }
        // Add a new delivery to the history (Create)
        public bool AddDeliveryToList(Delivery delivery)
        {
            if (!isOrderDateRight(delivery.OrderDate))
            {
                return false;
            }
            database.Add(delivery);
            return true;
        }

        public bool isOrderDateRight(string orderDate)
        {

            var date = orderDate.Split("-");

            if (date.Count() == 3)
            {
                return true;
            }
            return false;

        }

        // List all en route deliveries, and all completed deliveries (Read)
        public Delivery GetOneDeliveryFromListByItemNumber(string itemNumber)
        {
            Delivery d = new Delivery();
            foreach (Delivery delivery in database)
            {
                if (delivery.ItemNum == itemNumber)
                {
                    return delivery;
                }

            }

            return d;

        }

        // Update the status of a delivery (Update)
        public bool UpdateStatusOfDelivery(Delivery delivery)
        {
            int counter = 0;
            var d = new Delivery();
            foreach (Delivery del in database)
            {
                if (del.ItemNum == delivery.ItemNum)
                {
                    d = delivery;
                    break;
                }
                counter++;
            }

            database.RemoveAt(counter);
            database.Add(delivery);
            return true;
        }

        // Cancel a delivery (Delete)

        public bool RemoveDeliveryByItemNumber(string itemNumber)
        {
            int counter = 0;
            foreach (Delivery delivery in database)
            {
                if (delivery.ItemNum == itemNumber)
                {

                    break;
                }
                counter++;
            }
            database.RemoveAt(counter);
            return true;
        }

    }

}
