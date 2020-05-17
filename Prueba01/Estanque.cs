using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba01
{
    class Estanque : VehiculoComponentes
    {
        private double _capacidad;
        private double _litros;

        public Estanque(double capacidad, double litros, double estadoEstanque) : base(estadoEstanque)
        {
            _capacidad = capacidad;
            _litros = litros;
        }

        public Boolean MitadCombustible()
        {
            if(_litros > _capacidad * 0.105 && _litros <= _capacidad * 0.50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean BajoCombustible()
        {
            if(_litros < _capacidad * 0.105)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void IngresarDatosEstanque()
        {
            Console.Write("Ingrese la capacidad maxima del estanque: ");
            _capacidad = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese cuantos litros hay en el estanque: ");
            _litros = Convert.ToDouble(Console.ReadLine());

            while (_litros > _capacidad)
            {
                Console.WriteLine("\n--------------ERROR--------------");
                Console.WriteLine("Los litros no pueden ser mayor a la capacidad");
                Console.Write("Ingrese cuantos litros hay en el estanque: ");
                _litros = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("Ingrese el estado del estanque: ");
            EstadoComponente = Convert.ToDouble(Console.ReadLine());
        }

        public override string ToString()
        {
            return "Capacidad: " + _capacidad +
                " / Litros: " + _litros + 
                " / Bajo Combustible: " + BajoCombustible() +
                " / Mitad Combustible: " + MitadCombustible() +
                " / Estado Estanque: " + EstadoComponente + "%";
        }
    }
}
