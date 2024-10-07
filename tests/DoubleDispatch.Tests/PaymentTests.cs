using DoubleDispatch.Logic;
using FluentAssertions;

namespace DoubleDispatch.Tests;

public class PaymentTests
{
    private class UnsupportedRegion : Region
    {
    }
    
    public static IEnumerable<object[]> FeeCalculationTable()
    {
        var cardPayment = new CardPayment();
        var digitalWalletPayment = new DigitalWalletPayment();
        var bankTransferPayment = new BankTransferPayment();
        
        var europe = new Europe();
        var northAmerica = new NorthAmerica();
        
        yield return [cardPayment, europe, 0.60m];
        yield return [cardPayment, northAmerica, 0.40m];
        
        yield return [digitalWalletPayment, europe, 1.10m];
        yield return [digitalWalletPayment, northAmerica, 0.90m];
        
        yield return [bankTransferPayment, europe, 2.10m];
        yield return [bankTransferPayment, northAmerica, 2.75m];
    }

    [Theory]
    [MemberData(nameof(FeeCalculationTable))]
    public void Calculate_Fee(IPayment payment, Region region, decimal expectedFee)
    {
        var fee = payment.CalculateFee(region);
        
        fee.Should().Be(expectedFee);
    }
    
    [Fact]
    public void Handle_Unsupported_Region()
    {
        var payment = new CardPayment();
        var unsupportedRegion = new UnsupportedRegion();
        
        Action feeCalculation = () => payment.CalculateFee(unsupportedRegion);
        
        feeCalculation
            .Should()
            .Throw<InvalidOperationException>()
            .WithMessage("Unsupported region");
    }
}