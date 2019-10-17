using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    /*esta clase va ser la clase padre de donde las demas clases heredaran los 
     atributos de esta clase*/
    public class Cuenta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public double Interes { get; set; }


        public bool Ingreso()
        {
            return false;
        }

        /*en este metodo se calcula cuanto de intereses va a pagar el usuario 
         por cada mes */
        public double InteresMes(double interes)
        {
            var InMes = Interes * (0.16);
            Console.WriteLine("Su interes por mes es de $" + InMes);
            return InMes;
        }

        //este metodo es para colsultar su saldo 
        public void Consultar(Cuenta cuenta)
        {
            Console.WriteLine("Su Saldo Actual es de $" + Saldo);
        }
        /*este metodo va a funcionar para trasferir el dinero de cuanta a 
         cuenta */
        public void Transferir(Cuenta cuenta)
        {
            Console.WriteLine("Su saldo es de $" + Saldo);
            Console.WriteLine("___________________________");
            Console.WriteLine("Ingrese la cantidad a transferir");
            double Trans = Convert.ToDouble(Console.ReadLine());
            double Total = Saldo - Trans;
            Console.WriteLine("Usted a transferido $" + Trans);
            Console.WriteLine("El saldo total de tu cuenta es de $" + Total);
        }
        
    }
}
