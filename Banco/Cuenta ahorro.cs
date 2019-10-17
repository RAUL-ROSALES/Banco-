using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    /**/
    public class Cuenta_Ahorro:Cuenta
    {
        public DateTime Vencimiento { get; set; }

        public double IngresoXmes()
        {
            return 0;
        }
    }
}
