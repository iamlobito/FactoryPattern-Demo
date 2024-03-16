using FactoryPattern_Demo;

IPayment payment = PaymentFactory.Create(PaymentType.CreditCardPayment);
payment.Pay(200.00);

payment = PaymentFactory.Create(PaymentType.PaypalPayment);
payment.Pay(200.00);


payment = PaymentFactory.Create(PaymentType.GooglePayment);
payment.Pay(200.00);

Console.ReadLine();

