using System;

namespace Interfaces.Exceptions
{
    internal class PaymentExecption : Exception
    {
       public PaymentExecption(string msg) : base(msg) { }
    }
}

