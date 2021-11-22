using System;
using System.Globalization;
using Interfaces.Entities;

namespace Interfaces.Services
{
    internal class InputServices
    {
        public int number { get; set; }
        public DateTime date { get; set; }
        public double value { get; set; }
        public int installments { get; set; }
        public void Print()
        {
            Console.WriteLine("Enter Contratc Data");
            Console.Write("Number: ");
            number = Int32.Parse(Console.ReadLine());
            Console.Write("Date(dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract Value: ");
            value = double.Parse(Console.ReadLine());
            Console.Write("Enter number of installments: ");
            installments = Int32.Parse(Console.ReadLine());

            var contract = new Contract(number);
            var ins = new InstallmentsServices(date, value, installments, new PayPalPaymentServices());
            ins.ValueProcess(contract);

            Console.WriteLine(contract.Tela);
        }
    }
}
