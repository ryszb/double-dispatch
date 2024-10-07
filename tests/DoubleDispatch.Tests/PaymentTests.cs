using DoubleDispatch.Logic;
using FluentAssertions;

namespace DoubleDispatch.Tests;

public class PaymentTests
{
    public static IEnumerable<object[]> FeeCalculationTable()
    {
        yield return [new CardPayment(), 0.50m];
        yield return [new DigitalWalletPayment(), 1.00m];
        yield return [new BankTransferPayment(), 2.50m];
    }

    [Theory]
    [MemberData(nameof(FeeCalculationTable))]
    public void Calculate_Fee(IPayment payment, decimal expectedFee)
    {
        var fee = payment.CalculateFee();
        
        fee.Should().Be(expectedFee);
    }
}