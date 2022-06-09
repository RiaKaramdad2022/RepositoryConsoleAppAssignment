using System;
using RepositoryConsoleApp_Repository;


namespace RepositoryConsoleApp_Testing;

public class UnitTest1
{
    Delivery d = new Delivery();
    
    [Fact]
    public void TheRepositoryShouldAddElement()
    {
        DeliveryRepository repo = new DeliveryRepository();
        
        Delivery delivery = new Delivery("Feb-01-2022", "Jan-29-2022",StatusOrder.Scheduled);
        repo.AddDeliveryToList(delivery);

        var element = repo.database;

        Equals(delivery,element);
        // triple "A" paradigm
        // Delivery objectToCompare = new DeliveryRepository();
        // tobjectToCompare.ItemNumber = "1245FG";

        // //arrange
        // DeliveryRepository repo = new DeliveryRepository();

        // repo.database.Add(objectToCompare);

        // Delivery d = repo.GetOneDeliveryFromListByItemNumber("1245FG");

        //assert.Equals(d,test);
        //act
        

        //assert
    }
}


