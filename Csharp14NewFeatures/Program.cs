using Csharp14NewFeatures.Csharp14NewFeatures;

namespace Csharp14NewFeatures;

public class Program
{
    public static void Main()
    {

        #region Extension metmbers using block syntax - Math

        //Extension properties 
        double radians = double.Pi / 3.0; // Pi/3 radians = 60 degrees (1 * Pi = 180 degrees) 
        double degrees = radians * radians.Rad2Deg; // Using the extension method Rad2Deg

        Console.WriteLine($"Radians: {radians:F6}"); //outputs 1.04719..
        Console.WriteLine($"Degrees: {degrees:F6}"); //outputs 60

        //Using Extension methods 

        double radiansV2 = 1.0.GetPi() / 3.0;
        double degreesV2 = radians * 1.0.GetRad2Deg();

        Console.WriteLine($"Radians: {radiansV2:F6}");
        Console.WriteLine($"Degrees: {degreesV2:F6}");

        #endregion

        #region Extension members using extension block syntax 

        var numbers = new List<int> { 1, 2, 3 };
        Console.WriteLine($"Extension property used. Numbers is empty? {numbers.IsEmpty}");
        Console.WriteLine($"Extension property used. Numbers have items? {numbers.HasItems}");

        var moreNumbers = new List<int> { 4, 5, 6 };
        var combinedNumbers = numbers + moreNumbers; // Using the user-defined operator +

        Console.WriteLine($"Here is the sequence of combinednumbers: {string.Join(",", combinedNumbers)}");

        var evenMoreNumbers = new List<int> { 5, 3, 4 };

        var numbersExceptEvenMoreNumbers = numbers - evenMoreNumbers; // Using the user-defined operator -

        Console.WriteLine($"Here is the sequence of combinednumbers: {string.Join(",", numbersExceptEvenMoreNumbers)}");


        #endregion 

        #region NullReferenceAssignmentAndNewAccessors 

        var demos = new Csharp14NewFeaturesDemos
        {
            PropUsingRequiredCannotBeNullOrEmpty = "A test",
            PropUsingKeywordInit = 4999 // Value below 5000 to avoid ArgumentException
        };
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

        #endregion 
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


