namespace DoubleDispatch.Logic;

public class DigitalWalletPayment : IPayment
{
    public decimal CalculateFee(Region region)
    {
        return region.CalculateFeeForPayment(this);
    }
}