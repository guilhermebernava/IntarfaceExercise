using System;
using System.Collections.Generic;

namespace Interfaces.Entities
{
    internal class Tela
    {
        public List<double> List { get; private set; }
        public DateTime Start { get; private set; }

        public Tela(List<double> list,DateTime date)
        {
            List = list;
            Start = date;   
        }

        public override string ToString()
        {
            var aux = 1;
            foreach (double db in List)
            {
                Console.Write(Start.AddMonths(aux).ToString("dd/MM/yyy" ) + " - ");
                Console.WriteLine(db.ToString("F2"));
                aux++;
            }
            return "\n----------------------------------";
        }
    }  
}
