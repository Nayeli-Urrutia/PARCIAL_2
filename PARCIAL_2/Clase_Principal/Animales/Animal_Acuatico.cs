using PARCIAL_2.parcial_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL_2.Clase_Principal.Clase_Animales
{
    internal class Animal_Acuatico : Clases_de_Animales
    {
        public bool EsDepredador { get; set; }

       

        // Interface
        public override void Extremidades()
        {
            Console.WriteLine("El Tiburon Blanco tiene Aletas.");
        }

        // Delegado
        public void ImprimirH(ImprimirHDelegate imprimirDelegate)
        {
            imprimirDelegate();
        }
        public void Imprimirtib()
        {
            Console.WriteLine("Nombre Cientifico: Carcharodon carcharias");
        }

        // Declaración del evento basado en el delegado
        public event ImprimirHDelegate TiburonImpreso;

        public void ImprimirH()
        {
            // Verificar si hay suscriptores al evento
            if (TiburonImpreso != null)
            {

                TiburonImpreso();
            }
        }

        public string MostrarInformacionAC()
        {
            // Polimorfismo
            MostrarInformacion();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string ani = $"Es un Animal Depredador: {EsDepredador}";
            Extremidades();
            Imprimirtib();
            ImprimirH();

            return ani;

        }
    }
}
