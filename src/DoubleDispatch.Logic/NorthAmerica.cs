namespace DoubleDispatch.Logic;

public class NorthAmerica : Region
{
    public override decimal CalculateFeeForPayment(CardPayment payment)
    {
        // More complex fee calculation logic is implemented here,
        // but a fixed value is used for brevity
        
        return 0.40m;
    }

    public override decimal CalculateFeeForPayment(DigitalWalletPayment payment)
    {
        // More complex fee calculation logic is implemented here,
        // but a fixed value is used for brevity
        
        return 0.90m;
    }

    public override decimal CalculateFeeForPayment(BankTransferPayment payment)
    {
        // More complex fee calculation logic is implemented here,
        // but a fixed value is used for brevity
        
        return 2.75m;
    }
}