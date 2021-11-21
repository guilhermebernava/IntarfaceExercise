using System;
using Interfaces.Entities;
using Interfaces.Interfaces;

namespace Interfaces.Services
{
    class Installments
    {
        public DateTime Date { get; set; }
        public double Value { get; set; }
        public int Installament { get; set; }

        public IPayment _paymentService;

        public Installments(DateTime date, double value, int installament, IPayment paymentService)
        {
            Date = date;
            Value = value;
            Installament = installament;
            _paymentService = paymentService;
        }

        public void ValueProcess(Contract con)
        {
            var list = _paymentService.PaymentOnline(Value, Installament);
            con.Tela = new Tela(list,Date);
        }
    }
}
