using Prueba_Examen.Clases;
using Prueba_Examen.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Prueba_Examen.Servicios
{
    internal class Procedimientos
    {
        public Cliente cliente; 
        public Numeros numeros; 
        public Procedimientos()
        {
          cliente = new Cliente();
          numeros = new Numeros();
        }
        public void IngresarDatos()
        {
            Console.WriteLine("Bienvenido.");
            Console.Write("Ingrese su nombre: ");
            cliente.Nombre = Console.ReadLine();
            Console.Clear();
            Console.Write("Ingrese su Teléfono: ");
            cliente.Telefono = Console.ReadLine();
            Console.Clear();
            Console.Write("Ingrese su correo: ");
            cliente.Correo = Console.ReadLine();
        }
        public void IngresarPrecios()
        {
            Console.Clear();
            Console.WriteLine("Ingrese los precios de sus productos.");
            Console.WriteLine("Cuando termine de escribir el primero, presione la tecla enter.");
            numeros.num1 = double.Parse(Console.ReadLine());
            numeros.num2 = double.Parse(Console.ReadLine());
            numeros.num3 = double.Parse(Console.ReadLine());
            numeros.num4 = double.Parse(Console.ReadLine());
            numeros.num5 = double.Parse(Console.ReadLine());
        }

        public void SumaDeNumeros ()
        {
            Console.Clear ();
            double Total = numeros.num1 + numeros.num2 + numeros.num3 + numeros.num4 + numeros.num5;
            numeros.GuradarTotal = Total;
            //Descuento(Total);
            //TresMSI(Total);
            //SeisMSI(Total);
            //DoceMSI(Total);
        }
        #region DescuentosMSI
        public double Descuento(double Total)
        {
            Console.Clear();
            double Descuento = Total * .1;
            Descuento = Total - Descuento;
            numeros.GuradarTotal = Descuento;
            return Descuento;
        }

        public double TresMSI(double Total)
        {
            Console.Clear ();
            this.Descuento(Total);
            double TresMeses = Total / 3;
            numeros.GuradarTotal = TresMeses;
            return TresMeses;
        }

        public double SeisMSI(double Total)
        {
            Console.Clear();
            this.Descuento(Total);
            double SeisMeses = Total / 6;
            return SeisMeses;
        }

        public double DoceMSI(double Total)
        {
            Console.Clear();
            this.Descuento(Total);
            double DoceMeses = Total / 12;
            return DoceMeses;
        }
        #endregion
    }
}
