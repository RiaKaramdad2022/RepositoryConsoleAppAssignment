using System;
using RepositoryConsoleApp_Repository;

namespace RepositoryConsoleApp_Console
{
    public class ProgramUI
    {
        
            
        static void Main(string[] args)
        {
            DeliveryRepository repo = new DeliveryRepository();
            repo.DatabaseInit();           
            
            Console.WriteLine("Welcome to the Warner Tansit Federal. Please select an option in order to continue:");
            Console.WriteLine($"Take a look at deliveries:  1");
            Console.WriteLine($"Cancel delivery:            2");
            Console.WriteLine($"Update delivery:            3");
            
            var option = Console.ReadLine();

            switch(option){

                case "1": lookAtDeliveries(repo);
                            break;
                case "2": cancelDelivery();
                            break;
                case "3": updateDelivery();
                            default:
                            break;
            }         

            // To do

            Console.WriteLine("Input item number to get delivery details");

            string itemNumber = Console.ReadLine();

            Delivery d = repo.GetOneDeliveryFromListByItemNumber(itemNumber);

            Console.WriteLine("Item Number: "+d.ItemNum);
            Console.WriteLine("Delivery Date: "+d.DeliveryDate);
        }

        private static void lookAtDeliveries(DeliveryRepository repository){

            List<Delivery> database = repository.database;

            foreach(var element in database){
                Console.WriteLine(element);
            }
            
        }
        private static void cancelDelivery(){
            var Delivery = Delivery.ItemNum;
            OrderStatus = "Cancelled";

        }
        private static void updateDelivery(){
            var delivery = new delivery
            History.Add(delivery);
            CurrentInformation = delivery;
        }
    }
}