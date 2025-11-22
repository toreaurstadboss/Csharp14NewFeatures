namespace Csharp14NewFeatures;

public class Program
{
    public static void Main()
    {
        var demos = new Csharp14NewFeaturesDemos
        {
            PropUsingRequiredCannotBeNullOrEmpty = "A test",
            PropUsingKeywordInit = 4999 // Value below 5000 to avoid ArgumentException
        };
        demos.PropUsingFieldKeyword = "Hello, C# 14!";
        Console.WriteLine(demos.PropUsingFieldKeyword);


        //Demonstrate AnotherClass using null-conditional assignment 
        AnotherClass? anotherClass = null;
        anotherClass?.CurrentOrder = anotherClass?.ShipmentService.GetCurrentOrder();
        Console.WriteLine($"Current order retrieved using null-conditional assignment: {anotherClass?.CurrentOrder?.OrderId} Current order id is NULL? {anotherClass?.CurrentOrder?.OrderId is null}");

        anotherClass?.Counter += 2;
        Console.WriteLine($"anotherClass.Counter = {anotherClass?.Counter}. Is anotherClass.Counter NULL ? {anotherClass?.Counter is null} : outputs NULL since anotherClass is still null");
        anotherClass = new AnotherClass();
        anotherClass?.Counter -= 15;
        Console.WriteLine($"anotherClass.Counter = {anotherClass?.Counter} : outputs -15 since anotherClass is not null");
    }
}

public class Csharp14NewFeaturesDemos
{

    public required string PropUsingRequiredCannotBeNullOrEmpty
    {
        get;
        set
        {
            // 'required' accessor ensures the property must be set during object initialization
            field = value ?? throw new ArgumentNullException(nameof(value), "Value cannot be null.");   
        }
    }


    public int? PropUsingKeywordInit
    {
        get;
        init
        {
            // 'init' accessor allows setting the property only during object initialization
            field = value < 5000 ? value : throw new ArgumentException("Value must be below 5000.");
        }
    }


    public string? PropUsingFieldKeyword
    {
        get;
        set
        {
            Console.WriteLine("Possible to add code in the setter for C# auto prop. Keyword 'field' below sets a value to the field.");
            field = value;
        }
    }
}

public class AnotherClass
{
    public ShipmentService ShipmentService = new ShipmentService();
    public Order? CurrentOrder { get; set; }  
    public int? Counter { get; set; } = 0;   
}

public class ShipmentService
{
    public Order? GetCurrentOrder()
    {
        // Simulate fetching the current order, which may return null
        return null; // or return new Order { OrderId = 1234 };
    }
}

public class Order
{
    public int OrderId { get; set; }
}


