using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba01
{
    public abstract class VehiculoComponentes
    {
        private double _estadoComponente;

        public VehiculoComponentes(double estadoComponente)
        {
            _estadoComponente = estadoComponente;
        }

        public double EstadoComponente 
        { 
            get => _estadoComponente;
            set
            {
                while (value < 0 || value > 100)
                {
                    Console.WriteLine("\n--------------ERROR--------------");
                    Console.WriteLine("El estado del componente debe de estar en un rango de 0 a 100%");
                    Console.Write("Ingrese un valor valido: ");
                    value = Convert.ToDouble(Console.ReadLine());
                }

                _estadoComponente = value;
            }
        }
    }
}
