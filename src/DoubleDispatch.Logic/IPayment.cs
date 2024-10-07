namespace DoubleDispatch.Logic;

public interface IPayment
{
    // Other payment-related methods are omitted for brevity
    
    decimal CalculateFee(Region region);
}