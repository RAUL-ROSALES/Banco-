using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    public class Pensiones:Cuenta//herede los atributos de la clase cuneta 
    {
        /*aqui le damos atributos aparte a la clase pensiones*/
        public DateTime Vencimiento { get; set; }
        public int Cotizacion { get; set; }
        public int No_Cuenta { get; set; }

    }
}
