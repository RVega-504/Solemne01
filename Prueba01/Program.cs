using System;
using System.Collections;
using System.Collections.Generic;


namespace Prueba01
{
    class Program 
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();
            int opc;

            Console.WriteLine("--usuario: ADMIN--");
            Console.Write("Ingrese contraseña: ");
            string _pass = Console.ReadLine();

            while (_pass != "abc123")
            {
                Console.WriteLine("CONTRASEÑA INCORRECTA");
                Console.Write("Ingrese contraseña nuevamente: ");
                _pass = Console.ReadLine();
            }

            do
            {
                Console.WriteLine("\n-----Ingrese una opcion-----");
                Console.WriteLine("1: Ingresar Vehiculo");
                Console.WriteLine("2: Imprimir Vehiculos");
                Console.WriteLine("0: Salir");
                opc = Convert.ToInt32(Console.ReadLine());

                if (opc == 1)
                {
                    Automovil automovil = new Automovil(null, 0, 0,
                                new Estanque(0, 0, 0),
                                new Rueda(TipoRecubrimiento.FENOL, 0, 0, 0),
                                new Mezclador(TipoMezclador.CARBURADOR, 0),
                                new Motor(TipoMotor.CUATRO_TIEMPOS, 0, false, 0));

                    automovil.InscribirVehiculo();
                    array.Add(automovil);
                    Console.WriteLine();
                }
                else if (opc == 2)
                {
                    if(array.Count == 0)
                    {
                        Console.WriteLine("NO SE ENCONTRARON VEHICULOS REGISTRADOS");
                    }
                    else
                    {
                        for (int i = 0; i < array.Count; i++)
                        {
                            Console.WriteLine("\n---------------------------------");
                            Console.WriteLine("Automovil num: " + (i + 1));
                            Console.WriteLine(array[i]);
                        }
                    }
                }
            } while (opc != 0);
        }
    }
}
