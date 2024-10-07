namespace DoubleDispatch.Logic;

public class CardPayment : IPayment
{
    public decimal CalculateFee(Region region)
    {
        return region.CalculateFeeForPayment(this);
    }
}