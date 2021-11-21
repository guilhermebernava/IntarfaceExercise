using System;
using System.Globalization;
using Interfaces.Entities;
using Interfaces.Services;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Contratc Data");
            Console.Write("Number: ");
            int number = Int32.Parse(Console.ReadLine());
            Console.Write("Date(dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract Value: ");
            var value = double.Parse(Console.ReadLine());
            Console.Write("Enter number of installments: ");
            int installments = Int32.Parse(Console.ReadLine());

            var contract = new Contract(number);
            var ins = new Installments(date,value,installments,new PayPalPayment());
            ins.ValueProcess(contract);

            Console.WriteLine(contract.Tela);


        }
    }
}
