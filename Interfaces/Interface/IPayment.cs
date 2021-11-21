using System.Collections.Generic;

namespace Interfaces.Interfaces
{
    interface IPayment
    {
        List<double> PaymentOnline(double value,int installament);
    }
}
