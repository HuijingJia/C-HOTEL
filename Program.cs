namespace week6exercise2;

class Program
{
    static void Main(string[] args)
    {
        LuxuryHotel luxuryHotel = new LuxuryHotel("A", "LA");
        luxuryHotel.OfferServices();
        BudgetHotel budgetHotel = new BudgetHotel("B", "San Jose");
        budgetHotel.OfferServices();
        Console.WriteLine($"LuxuryHotel at {luxuryHotel.HotelName} in {luxuryHotel.City}, {luxuryHotel.OfferServices()}");
        Console.WriteLine($"BugdetHotel at {budgetHotel.HotelName} in {budgetHotel.City}, {budgetHotel.OfferServices()}");
        Console.ReadLine();
    }
}
public abstract class Hotel
{
    // two properties:
    public string HotelName { get; set; }
    public string City { get; set; }

    // add an abstract method name:
    public abstract string OfferServices();

    //Add a constructor to each derived class that takes in parameters for the hotel name and city and initializes the properties accordingly.
    public Hotel(string hotelName, string city)
    {
        HotelName = hotelName;
        City = city;
    }
}
public class LuxuryHotel:Hotel
{
    public LuxuryHotel(string hotelName, string city) : base(hotelName, city)
    {
    //    HotelName = hotelName;
    //    City = city;
    }
    public override string OfferServices()
    {
        return "Offering spa, gym, and pool facilities.";    
    }
}
public class BudgetHotel : Hotel
{
    public BudgetHotel(string hotelName, string city) : base(hotelName, city)
    {
        //HotelName = hotelName;
        //City = city;
    }
    public override string OfferServices()
    {
        return "Offering free Wi-Fi and breakfast.";
    }
}


