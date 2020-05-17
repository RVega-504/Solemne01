using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba01
{
    enum TipoRecubrimiento
    {
        FENOL, HULE, POLIUTERANO
    }
    class Rueda : VehiculoComponentes
    {

        private TipoRecubrimiento _recubrimiento;
        private int _minDurometro;
        private int _maxDurometro;

        public Rueda(TipoRecubrimiento recubrimiento, int minDurometro, int maxDurometro, double estadoRueda) : base(estadoRueda)
        {
            _recubrimiento = recubrimiento;
            _minDurometro = minDurometro;
            _maxDurometro = maxDurometro;
            EstadoComponente = estadoRueda;
        }

        //Asigno datos a los atributos de la clase
        public void IngresarDatosRueda()
        {
            Console.WriteLine("Tipo de recubrimiento de la rueda");
            Console.WriteLine("Ingrese 1 para FENOL");
            Console.WriteLine("Ingrese 2 para HULE");
            Console.WriteLine("Ingrese 3 para POLIUTIRANO");

            int opc = 0;

            while (opc != 1 && opc != 2 && opc != 3)
            {
                opc = Convert.ToInt32(Console.ReadLine());
                if (opc == 1)
                {
                    _recubrimiento = TipoRecubrimiento.FENOL;
                }
                else if (opc == 2)
                {
                    _recubrimiento = TipoRecubrimiento.HULE;
                }
                else if (opc == 3)
                {
                    _recubrimiento = TipoRecubrimiento.POLIUTERANO;
                }
                else
                    Console.Write("Ingrese una opcion valida: ");
            }

            Console.Write("Ingrese minDurometro: ");
            _minDurometro = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese maxDurometro: ");
            _maxDurometro = Convert.ToInt32(Console.ReadLine());

            while (_minDurometro > _maxDurometro)
            {
                Console.WriteLine("El dato minDurometro debe de ser menor a maxDurometro");
                Console.Write("Ingrese minDurometro: ");
                _minDurometro = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese maxDurometro: ");
                _maxDurometro = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Ingrese el estado de la rueda: ");
            EstadoComponente = Convert.ToDouble(Console.ReadLine());
        }

        public override string ToString()
        {
            return "Recubrimiento: " + _recubrimiento + 
                " / MinDurometro: " + _minDurometro + 
                " / MaxDurometro: " + _maxDurometro + 
                " / Estado Rueda: " + EstadoComponente + "%";
        }
    }
}
