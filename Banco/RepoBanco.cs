using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    /*creo la clase repobanco */
    public class RepoBanco
    {
        
        Datos_Cuenta dc;/*instancio la clase datos_cuenta global para
        poder acceder a ella desde cualquier metodo */
        public RepoBanco()
        {
            dc = new Datos_Cuenta(); 
        }

        internal void Principal()
        {
           
            Console.WriteLine("BIENVENIDO AL Banco De Mexico");
            Menu();
            Console.ReadLine();
        }

        private void Menu()
        {
            /*este es el primer menu que se despleja 
             cuando se corra el programa y el usuiario 
             va a elejir su tipo de cuenta*/
            Console.WriteLine("Elija una opcion");
            Console.WriteLine("1-Cuenta ahorro");
            Console.WriteLine("2-Pensiones");
            Console.WriteLine("3-Cuenta Corriente");
            string opc = Console.ReadLine();
            switch (opc)
            {
                case "1":
                    Console.WriteLine("Bienvenido a la Cuenta ahorro");
                    Obtener_Datos_Ahorro();
                    break;

                case "2":
                    Console.WriteLine("Bienvenido a Pensiones");
                    Obtener_Datos_Pension();
                    break;

                case "3":
                    Console.WriteLine("Bienvenido a la Cuenta Corriente");
                    Obtener_Datos_Corriente();
                    break;

                default:
                    break;
            }

        }
        /*aqui compara el numero que ingresa el usuario*/
        private void Obtener_Datos_Corriente()
        {
            int Num = ObtenerDatos();
            var listaa = dc.Corrientes();
            Cuenta_Corriente co = new Cuenta_Corriente();

            foreach (var account in listaa)
            {
                if (Num == account.Numero)
                {
                    co = account;
                }

            }

            Console.WriteLine("Bienvenido " + co.Titular);
            MenuUs(co);/*cuando ya se verifico el numero de cuanta se desplega el el menu 
            usuario*/
        }

        private int ObtenerDatos()
            /*este metod va a guaradar el numero de cuenta para compararlo con los demas 
              numeros */
             
        {
            Console.WriteLine("Ingrese su numero de cuenta");
            string cue = Console.ReadLine();
            return Convert.ToInt32(cue);
        }

        private void Obtener_Datos_Pension()
        {
            int Num = ObtenerDatos();
            var listaa = dc.Pensiones();
            Pensiones pe = new Pensiones();
            //aquie el foreach compara si el numero de cuenta con las cuentas que existen
            foreach (var account in listaa)
                {
                if (Num == account.Numero)
                {
                    pe = account;
                }
            }
            Console.WriteLine("Bienvenido " + pe.Titular);
            MenuUs(pe);
        }

        private void Obtener_Datos_Ahorro()
        {
            int Num = ObtenerDatos();
            var listaaa = dc.Ahorros();
            Cuenta_Ahorro pe = new Cuenta_Ahorro();

            foreach (var account in listaaa)
            {
                if (Num == account.Numero)
                {
                    pe = account;
                }
            }

            Console.WriteLine("Bienvenido " + pe.Titular);

            MenuUs(pe);
        }
        /*este va a hacer el menu que se va a desplegar en cada una 
         de las cuentas que existen*/
        private void MenuUs(Cuenta pe)
        {            
            Console.Clear();
            Console.WriteLine("Bienvenido " + pe.Titular);
            Console.WriteLine("Eliga una opcion");
            Console.WriteLine("opc1.- Consultar saldo");
            Console.WriteLine("opc2.- Transferir Saldo");
            Console.WriteLine("opc3.- Interes por mes");
            Console.WriteLine("opc4.- Ingresar Saldo");
            double x = pe.Saldo;
            String m = Console.ReadLine();
            switch (m)
            {
                case "1":
                    pe.Consultar(pe);
                    break;

                case "2":

                    pe.Transferir(pe);
                    break;

                case "3":
                    double xt = pe.InteresMes(x);
                    break;

                case "4":
                    break;

                default:
                    break;                
            }
        }
    }
}
