using DoubleDispatch.Logic;

IPayment payment = new CardPayment();
Region region = new Europe();

var fee = payment.CalculateFee(region);