using Prueba_Examen.Clases;
using Prueba_Examen.Entidades;
using System;

namespace Prueba_Examen.Servicios
{
    public class Menu
    {
        public void Opciones()
        {
            int Opcion = 0;
            int Elegir = 0;

            Procedimientos procedimientos = new Procedimientos();

            procedimientos.IngresarDatos();
            procedimientos.IngresarPrecios();
            procedimientos.SumaDeNumeros();

            double Verificación = procedimientos.numeros.GuradarTotal;

            //Sin descuento ni msi
            if (Verificación < 5000)
            {
                Opcion = 0;
            }

            //Con descuento del 10%
            if (Verificación > 4999 && Verificación < 8000)
            {
                Opcion = 1;
            }

            //Descuento y opcion de 3 msi
            if (Verificación > 7999 && Verificación < 12000)
            {
                Opcion = 2;
            }

            //Descuento y opción de 6 o 12 msi
            if (Verificación > 11999)
            {
                Opcion = 3;
            }

            switch (Opcion)
            {
                case 0: //no se le hace descuento

                    Console.WriteLine($"Su total es de {Verificación}");

                    break;
                case 1: //solo descuento del 10%

                    Console.WriteLine("Su compra fue seleccionada para un descuento del 10%");

                    procedimientos.Descuento(Verificación);
                    Console.Write("Su total es de: ");
                    Console.WriteLine(procedimientos.numeros.GuradarTotal);

                    break;
                case 2: //Descuento y opcion de 3 msi

                    Console.WriteLine("Felicidades su compra es elegible para meses sin intereses");
                    Console.WriteLine("Precione 1 si quiere 3 meses sin intereses");
                    Console.WriteLine("Precione 2 si no lo quiere.");

                    do
                    {
                        Elegir = int.Parse(Console.ReadLine());

                        if (Elegir == 1)
                        {
                            procedimientos.Descuento(Verificación);
                            procedimientos.TresMSI(Verificación);
                        }
                        else
                        {
                            procedimientos.Descuento(Verificación);
                        }
                    } while (Elegir > 0 && Elegir < 3);
                    break;
                case 3: //Descuento y opción de 6 o 12 msi

                    Console.WriteLine("Felicidades su compra es elegible para meses sin intereses");
                    Console.WriteLine("Precione 1 si quiere 6 meses sin intereses");
                    Console.WriteLine("precione 3 si quiere 12 meses sin intereses");
                    Console.WriteLine("Precione 4 si no lo quiere.");
                    do
                    {
                        Elegir = int.Parse(Console.ReadLine());

                        if (Elegir == 1)
                        {
                            procedimientos.Descuento(Verificación);
                            procedimientos.SeisMSI(Verificación);
                        }
                        if (Elegir == 2)
                        {
                            procedimientos.Descuento(Verificación);
                            procedimientos.DoceMSI(Verificación);
                        }
                        if (Elegir == 3)
                        {
                            procedimientos.Descuento(Verificación);
                        }
                    } while (Elegir > 0 && Elegir < 5);
                break;
            }
            procedimientos.ImprimirDatos();
        }
    }
}
