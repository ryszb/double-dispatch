namespace DoubleDispatch.Logic;

public class CardPayment : IPayment
{
    public decimal CalculateFee()
    {
        // More complex fee calculation logic is implemented here,
        // but a fixed value is used for brevity
        
        return 0.50m;
    }
}