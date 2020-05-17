using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba01
{
    class Automovil : Vehiculo
    {
        private string _marca;
        private int _año;
        private double _kilometraje;

        Estanque _estanque = new Estanque(0, 0, 0);
        Rueda _rueda = new Rueda(TipoRecubrimiento.FENOL, 0, 0, 0);
        Mezclador _mezclador = new Mezclador(TipoMezclador.CARBURADOR, 0);
        Motor _motor = new Motor(TipoMotor.CUATRO_TIEMPOS, 0, false, 0);

        public Automovil(string marca, int año, double kilometraje, Estanque estanque, Rueda rueda, Mezclador mezclador, Motor motor)
        {
            _marca = marca;
            _año = año;
            _kilometraje = kilometraje;
            _estanque = estanque;
            _rueda = rueda;
            _mezclador = mezclador;
            _motor = motor;
        }

        //Asigno datos a los atributos y objetos de la clase
        public void InscribirVehiculo()
        {
            Console.WriteLine("\n-----Inscripcion de vehiculo-----");

            Console.Write("Ingrese marca: ");
            _marca = Console.ReadLine();

            Console.Write("Ingrese año: ");
            _año = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese kilometraje: ");
            _kilometraje = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n--------------Rueda--------------");
            _rueda.IngresarDatosRueda();

            Console.WriteLine("\n------------Mezclador------------");
            _mezclador.IngresarDatosMezclador();

            Console.WriteLine("\n--------------Motor--------------");
            _motor.IngresarDatosMotor();

            Console.WriteLine("\n------------Estanque-------------");
            _estanque.IngresarDatosEstanque();
        }

        public override string ToString()
        {
            return "Marca: " + _marca +
                "\nAño: " + _año + 
                "\nKilometraje: " + _kilometraje + 
                "\nDatos Estanque: " + _estanque + 
                "\nDatos Rueda: " + _rueda + 
                "\nDatos Mesclador: " + _mezclador + 
                "\nDatosMotor: " + _motor;
        }
    }
}
