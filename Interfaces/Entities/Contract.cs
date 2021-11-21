using System;

namespace Interfaces.Entities
{
     class Contract
    {
        public int Number { get; set; }
        public Tela Tela { get; set; }

        public Contract(int number)
        {
            Number = number;
            Tela = null;
        }
    }
}
