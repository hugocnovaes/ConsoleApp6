using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    public class Sandero : ICarro
    {
        public void IniciarMotor()
        {
            Console.WriteLine("Iniciando motor sandero...");
            Console.WriteLine("Girando engrenagem do sandero...");
        }
    }
}
