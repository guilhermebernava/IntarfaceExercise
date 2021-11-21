using Interfaces.Exceptions;
using Interfaces.Interfaces;
using System.Collections.Generic;

namespace Interfaces.Services
{
    internal class PayPalPayment : IPayment
    {
        public List<double> PaymentOnline(double value, int installament)
        {
            List<double> list = new List<double>();
            if (value == null && value < 0)
            {
                throw new PaymentExecption("Value has to be plus than 0");
                if (installament < 0 && installament == null)
                {
                    throw new PaymentExecption("Installament has to be plus than 0");
                }
            }

            var quota = value / installament;

            for (int i = 0; i < installament; i++)
            {
                quota *= 1.01;
                quota *= 1.02;
                list.Add(quota);
            }

            return list;
        }
    }
}
