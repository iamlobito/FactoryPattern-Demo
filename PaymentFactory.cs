using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_Demo
{
    public class PaymentFactory 
    {
        public static IPayment Create(PaymentType paymentType)
        {
            switch (paymentType)
            {
                case PaymentType.CreditCardPayment:
                    return new CreditCardPayment(); 
                case PaymentType.PaypalPayment: 
                    return new PaypalPayment();
                case PaymentType.GooglePayment
                    : return new GooglePayment();
                default:
                    throw new NotSupportedException($"Payment {paymentType} is not supported at the moment!");
            }
        }
    }
}
