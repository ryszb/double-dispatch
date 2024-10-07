namespace DoubleDispatch.Logic;

public class BankTransferPayment : IPayment
{
    public decimal CalculateFee()
    {
        // More complex fee calculation logic is implemented here,
        // but a fixed value is used for brevity
        
        return 2.50m;
    }
}