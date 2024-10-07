namespace DoubleDispatch.Logic;

public class Europe : Region
{
    public override decimal CalculateFeeForPayment(CardPayment payment)
    {
        // More complex fee calculation logic is implemented here,
        // but a fixed value is used for brevity
        
        return 0.60m;
    }

    public override decimal CalculateFeeForPayment(DigitalWalletPayment payment)
    {
        // More complex fee calculation logic is implemented here,
        // but a fixed value is used for brevity
        
        return 1.10m;
    }

    public override decimal CalculateFeeForPayment(BankTransferPayment payment)
    {
        // More complex fee calculation logic is implemented here,
        // but a fixed value is used for brevity
        
        return 2.10m;
    }
}