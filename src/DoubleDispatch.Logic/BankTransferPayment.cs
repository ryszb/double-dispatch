namespace DoubleDispatch.Logic;

public class BankTransferPayment : IPayment
{
    public decimal CalculateFee(Region region)
    {
        return region.CalculateFeeForPayment(this);
    }
}