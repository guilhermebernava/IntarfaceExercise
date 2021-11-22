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
            InputServices inputServices = new InputServices();
            inputServices.Print();
        }
    }
}
