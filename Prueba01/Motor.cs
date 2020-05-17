using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba01
{
    enum TipoMotor { 
        DOS_TIEMPO, CUATRO_TIEMPOS
    }
    class Motor : VehiculoComponentes
    {
        private TipoMotor _tipo;
        private int _id;
        private bool _cilindrada;

        public Motor(TipoMotor tipo, int id, bool cilindrada, double estadoMotor) : base(estadoMotor)
        {
            _tipo = tipo;
            _id = id;
            _cilindrada = cilindrada;
            EstadoComponente = estadoMotor;
        }

        public void IngresarDatosMotor()
        {
            Console.WriteLine("Tipo de motor");
            Console.WriteLine("Ingrese 1 para CUATRO_TIEMPOS");
            Console.WriteLine("Ingrese 2 para DOS_TIEMPO");

            int opcTipo = 0;

            while (opcTipo != 1 && opcTipo != 2)
            {
                opcTipo = Convert.ToInt32(Console.ReadLine());
                if (opcTipo == 1)
                {
                    _tipo = TipoMotor.CUATRO_TIEMPOS;
                }
                else if (opcTipo == 2)
                {
                    _tipo = TipoMotor.DOS_TIEMPO;
                }
                else
                    Console.Write("Ingrese una opcion valida: ");
            }

            Console.WriteLine("¿Es Cilindrada?");
            Console.WriteLine("Ingrese 1 para seleccionar 'SI'");
            Console.WriteLine("Ingrese 2 para seleccionar 'NO'");

            int opcBool = 0;

            while(opcBool != 1 && opcBool != 2)
            {
                opcBool = Convert.ToInt32(Console.ReadLine());
                if (opcBool == 1)
                {
                    _cilindrada = true;
                }
                else if (opcBool == 2)
                {
                    _cilindrada = false;
                }
                else
                    Console.Write("Ingrese una opcion valida: ");
            }

            Console.Write("Ingrese id del motor: ");
            _id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el estado del motor: ");
            EstadoComponente = Convert.ToDouble(Console.ReadLine());
        }

        public override string ToString()
        {
            return "Tipo: " + _tipo + 
                " / ID: " + _id + 
                " / Cilindrada: " + _cilindrada + 
                " / Estado Motor: " + EstadoComponente + "%";
        }
    }
}
