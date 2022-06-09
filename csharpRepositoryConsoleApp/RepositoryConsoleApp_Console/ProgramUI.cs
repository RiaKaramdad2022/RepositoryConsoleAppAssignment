using System;
using RepositoryConsoleApp_Repository;

namespace RepositoryConsoleApp_Console
{
    public class ProgramUI
    {
        
            
        static void Main(string[] args)
        {
            bool continueToRun = true;
            DeliveryRepository repo = new DeliveryRepository();
            repo.DatabaseInit();           
            do 
                {
                Console.WriteLine("Welcome to the Warner Tansit Federal. Please select an option in order to continue:");
                Console.WriteLine($"Take a look at deliveries:  1");
                Console.WriteLine($"Cancel delivery:            2");
                Console.WriteLine($"Update delivery:            3");
                Console.WriteLine($"Add delivery:               4");
                
                var option = Console.ReadLine();
                // string itemNumber = Console.ReadLine();
                // Delivery d = repo.GetOneDeliveryFromListByItemNumber(itemNumber);

                switch(option){

                    case "1": lookAtDeliveries(repo);
                            break;
                    case "2": cancelDelivery(repo);
                            break;
                 //   case "3": updateDelivery();
                   //         break;
                    case "4": AddDelivery(repo);
                            break;
                    default:
                    Console.WriteLine("Input not recognized");
                    continueToRun = false;
                            break;
                }         
                } while (continueToRun);
            // To do

            // Console.WriteLine("Input item number to get delivery details");
            // Console.WriteLine("Item Number: "+d.ItemNum);
            // Console.WriteLine("Delivery Date: "+d.DeliveryDate);
        }

        private static void lookAtDeliveries(DeliveryRepository repository){

            List<Delivery> database = repository.database;

            foreach(var element in database){
                Console.WriteLine(element);
            }
        }

        private static void cancelDelivery(DeliveryRepository database){
            //DeliveryRepository canrepo = new DeliveryRepository();
            Console.WriteLine("Enter ID number: ");
            string itemNumber = Console.ReadLine();
           //canrepo.RemoveDeliveryByItemNumber(itemNumber);
            Console.WriteLine("Cancelled");
            database.RemoveDeliveryByItemNumber(itemNumber);
            // Var Delivery = Delivery.ItemNum;
            // OrderStatus = "Cancelled";

        }
        private static void updateDelivery(Delivery delivery){
            DeliveryRepository updrepo = new DeliveryRepository();
            updrepo.UpdateStatusOfDelivery(delivery);
            Console.WriteLine("Updated");
        }

        public static void AddDelivery(DeliveryRepository database)
        {
            System.Console.WriteLine("Add a delivery menu");
            string orderDate = Console.ReadLine();
            string deliveryDate = Console.ReadLine();
            string StatusOfOrder = Console.ReadLine();
            StatusOrder statusOrder = Enum.Parse<StatusOrder>(StatusOfOrder, true);
            Delivery test = new Delivery(orderDate, deliveryDate, statusOrder);
            database.AddDeliveryToList(test);

        }
    }
}