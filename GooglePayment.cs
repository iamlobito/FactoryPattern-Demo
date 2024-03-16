using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_Demo
{
    public class GooglePayment : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Pay {amount} with Google Payment");
        }
    }
}
