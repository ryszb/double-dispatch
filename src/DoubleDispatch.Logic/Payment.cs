namespace DoubleDispatch.Logic;

public abstract class Payment : IPayment
{
    private readonly Dictionary<Type, Func<Region, decimal>> _feeCalculationMap;

    protected Payment()
    {
        _feeCalculationMap = new Dictionary<Type, Func<Region, decimal>>
        {
            { typeof(Europe), region => CalculateFeeForRegion((Europe)region) },
            { typeof(NorthAmerica), region => CalculateFeeForRegion((NorthAmerica)region) }
        };
    }

    public decimal CalculateFee(Region region)
    {
        if (_feeCalculationMap.TryGetValue(region.GetType(), out var calculateFeeMethod))
        {
            return calculateFeeMethod(region);
        }

        throw new InvalidOperationException("Unsupported region");
    }
    
    protected abstract decimal CalculateFeeForRegion(Europe region);
    
    protected abstract decimal CalculateFeeForRegion(NorthAmerica region);
}