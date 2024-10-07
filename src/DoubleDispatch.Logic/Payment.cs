namespace DoubleDispatch.Logic;

public abstract class Payment : IPayment
{
    public decimal CalculateFee(dynamic region)
    {
        return CalculateFeeForRegion(region);
    }
    
    protected abstract decimal CalculateFeeForRegion(Europe region);
    
    protected abstract decimal CalculateFeeForRegion(NorthAmerica region);
    
    private decimal CalculateFeeForRegion(Region region)
    {
        throw new InvalidOperationException($"Unsupported region");
    }
}