using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarro carro = Fabrica.InicializarCarro(TipoCarro.Celta);
            carro.IniciarMotor();

            Console.ReadLine();
        }
    }
}
