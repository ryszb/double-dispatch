namespace DoubleDispatch.Logic;

public abstract class Region
{
    public abstract decimal CalculateFeeForPayment(CardPayment payment);
    
    public abstract decimal CalculateFeeForPayment(DigitalWalletPayment payment);
    
    public abstract decimal CalculateFeeForPayment(BankTransferPayment payment);
}