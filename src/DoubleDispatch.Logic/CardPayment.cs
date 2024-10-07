namespace DoubleDispatch.Logic;

public class CardPayment : Payment
{
    protected override decimal CalculateFeeForRegion(Europe region)
    {
        // More complex fee calculation logic is implemented here,
        // but a fixed value is used for brevity
        
        return 0.60m;
    }

    protected override decimal CalculateFeeForRegion(NorthAmerica region)
    {
        // More complex fee calculation logic is implemented here,
        // but a fixed value is used for brevity
        
        return 0.40m;
    }
}