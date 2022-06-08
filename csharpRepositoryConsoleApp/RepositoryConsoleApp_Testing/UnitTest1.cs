namespace RepositoryConsoleApp_Testing;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // triple "A" paradigm
        Delivery objectToCompare = new DeliveryRepository();
        tobjectToCompare.ItemNumber = "1245FG";

        //arrange
        DeliveryRepository repo = new DeliveryRepository();

        repo.database.Add(objectToCompare);

        Delivery d = repo.GetOneDeliveryFromListByItemNumber("1245FG");

        assert.Equals(d,test)
        //act
        //
        //assert

    }
}