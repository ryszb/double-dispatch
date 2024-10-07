using DoubleDispatch.Logic;

IPayment payment = new CardPayment();

var fee = payment.CalculateFee();