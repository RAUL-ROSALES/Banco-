using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    /*esta clase va hacer para crear al objeto*/
    public class Datos_Cuenta
    {
        /*aqui creamos un metodo de tipo lista para 
         crear varios objetos */
        public List<Pensiones> Pensiones()
        {
            List<Pensiones> pensiones = new List<Pensiones>();
            /*aqui estamos creando los objetos para la clase pensiones*/
            pensiones.Add(new Pensiones { No_Cuenta = 12345, Cotizacion = 12, Interes = 1000, Numero = 12345, Saldo = 1000, Titular = "Raul", Vencimiento = Convert.ToDateTime("01/07/2024") });
            pensiones.Add(new Pensiones { No_Cuenta = 23456, Cotizacion = 12, Interes = 1000, Numero = 42323, Saldo = 45454, Titular = "Miguel Toño", Vencimiento = Convert.ToDateTime("10/08/2024") });
            pensiones.Add(new Pensiones { No_Cuenta = 34567, Cotizacion = 12, Interes = 16, Numero = 42323, Saldo = 45454, Titular = "Pepe Toño", Vencimiento = Convert.ToDateTime("24/09/2024") });
            pensiones.Add(new Pensiones { No_Cuenta = 47890, Cotizacion = 12, Interes = 16, Numero = 42323, Saldo = 45454, Titular = "Jesus el dios", Vencimiento = Convert.ToDateTime("09/12/2024") });
            pensiones.Add(new Pensiones { No_Cuenta = 10111, Cotizacion = 12, Interes = 12, Numero = 42423, Saldo = 45424, Titular = "Paquito ", Vencimiento = Convert.ToDateTime("12/12/2024") });
            return pensiones;
        }

        public List<Cuenta_Ahorro> Ahorros()
        {  
            /*aqui estamos creando los objetos para la clase Ahorro*/
            List<Cuenta_Ahorro> ahorros = new List<Cuenta_Ahorro>();
            ahorros.Add(new Cuenta_Ahorro { Interes = 11, Numero = 12345, Saldo = 453545.654, Titular = "Paco Alcaraz", Vencimiento = Convert.ToDateTime("24/07/2024") });
            ahorros.Add(new Cuenta_Ahorro { Interes = 13, Numero = 42323, Saldo = 45454, Titular = "Guadalupe", Vencimiento = Convert.ToDateTime("14/07/2024") });
            ahorros.Add(new Cuenta_Ahorro { Interes = 34, Numero = 42323, Saldo = 45454, Titular = "ian gael", Vencimiento = Convert.ToDateTime("24/07/2024") });
            ahorros.Add(new Cuenta_Ahorro { Interes = 12, Numero = 42323, Saldo = 45454, Titular = "Lamberto Quintero", Vencimiento = Convert.ToDateTime("14/07/2024") });
            ahorros.Add(new Cuenta_Ahorro {  Interes = 12, Numero = 42423, Saldo = 45424, Titular = "Chalino Sanchez", Vencimiento = Convert.ToDateTime("24/07/2024") });
            return ahorros;
        }

        public List<Cuenta_Corriente> Corrientes()
        {
            List<Cuenta_Corriente> corrientes = new List<Cuenta_Corriente>();
            return corrientes;
        }

    }
}
