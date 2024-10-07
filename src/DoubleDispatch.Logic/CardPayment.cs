namespace DoubleDispatch.Logic;

public class CardPayment : IPayment
{
    public decimal CalculateFee(Region region)
    {
        if (region is Europe europe)
        {
            return CalculateFeeForRegion(europe);
        }

        if (region is NorthAmerica northAmerica)
        {
            return CalculateFeeForRegion(northAmerica);
        }

        throw new InvalidOperationException("Unsupported region");
    }
    
    private decimal CalculateFeeForRegion(Europe region)
    {
        // More complex fee calculation logic is implemented here,
        // but a fixed value is used for brevity
        
        return 0.60m;
    }
    
    private decimal CalculateFeeForRegion(NorthAmerica region)
    {
        // More complex fee calculation logic is implemented here,
        // but a fixed value is used for brevity
        
        return 0.40m;
    }
}