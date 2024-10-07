namespace DoubleDispatch.Logic;

public abstract class Payment : IPayment
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
    
    protected abstract decimal CalculateFeeForRegion(Europe region);
    
    protected abstract decimal CalculateFeeForRegion(NorthAmerica region);
}