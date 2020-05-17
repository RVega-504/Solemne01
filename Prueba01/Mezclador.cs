using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba01
{
    enum TipoMezclador{
        CARBURADOR, MEZCLADOR
    }

    class Mezclador : VehiculoComponentes
    {
        private TipoMezclador _tipo;

        public Mezclador(TipoMezclador tipo, double estadoMezclador): base(estadoMezclador) 
        {
            _tipo = tipo;
            EstadoComponente = estadoMezclador;
        }

        //Asigno datos a los atributos de la clase
        public void IngresarDatosMezclador()
        {
            Console.WriteLine("Tipo mezclador");
            Console.WriteLine("Ingrese 1 para CARBURADOR");
            Console.WriteLine("Ingrese 2 para MEZCLADOR");

            int opc = 0;

            while (opc != 1 && opc != 2)
            {
                opc = Convert.ToInt32(Console.ReadLine());
                if (opc == 1)
                {
                    _tipo = TipoMezclador.CARBURADOR;
                }
                else if (opc == 2)
                {
                    _tipo = TipoMezclador.MEZCLADOR;
                }
                else
                    Console.Write("Ingrese una opcion valida: ");
            }

            Console.Write("Ingrese el estado del mezclador: ");
            EstadoComponente = Convert.ToDouble(Console.ReadLine());
        }

        public override string ToString()
        {
            return "Tipo: " + _tipo +
                " / Estado Mezclador: " + EstadoComponente + "%";
        }
    }
}
