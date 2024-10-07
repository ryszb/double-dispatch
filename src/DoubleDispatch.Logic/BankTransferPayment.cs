namespace DoubleDispatch.Logic;

public class BankTransferPayment : IPayment
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
        
        return 2.10m;
    }
    
    private decimal CalculateFeeForRegion(NorthAmerica region)
    {
        // More complex fee calculation logic is implemented here,
        // but a fixed value is used for brevity
        
        return 2.75m;
    }
}