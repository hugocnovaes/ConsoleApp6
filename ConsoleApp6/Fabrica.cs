using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    public static class Fabrica
    {
        public static ICarro InicializarCarro(TipoCarro tipo)
        {
            switch (tipo)
            {
                case TipoCarro.Sandero:
                    return new Sandero();
                case TipoCarro.Uno:
                    return new Uno();
                case TipoCarro.Celta:
                    return new Celta();
                default:
                    return null;
            }
        }
    }
}
