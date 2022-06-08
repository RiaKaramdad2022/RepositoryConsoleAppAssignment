using System;

namespace RepositoryConsoleApp_Console
{
    public class ProgramUI
    {
        static void Main(string[] args)
        {
            DeliveryRepository repo = new DeliveryRepository();
            repo.DatabaseInit();


            //Todo

            Console.WriteLine("Input item number to get delivery details");

            string itemNumber = Console.ReadLine();

            Delivery d = repo.GetOneDeliveryFromListByItemNumber(itemNumber);

            Console.WriteLine("Item Number: "+d.ItemNumber);
            Console.WriteLine("Delivery Date: "+d.DeliveryDate);





        }
    }
}