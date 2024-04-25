using PARCIAL_2.parcial_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL_2.Clase_Principal.Animales
{
    internal class Animal_Domestico : Clases_de_Animales
    {

        public bool EsDeCasa { get; set; }

        //interface
        public override void Extremidades()
        {
            Console.WriteLine("El perro tiene 4 patas.");
        }

        // Delegado
        public void ImprimirH(ImprimirHDelegate imprimirDelegate)
        {
            imprimirDelegate();
        }

        public void ImprimirPer()
        {
            Console.WriteLine("Nombre Cientifico: Canis lupus familiaris");
        }

        // Declaración del evento basado en el delegado
        public event ImprimirHDelegate PerroImpreso;

        public void ImprimirP()
        {
            // Verificar si hay suscriptores al evento
            if (PerroImpreso != null)
            {

                PerroImpreso();

            }
        }

        public string MostrarInformacionAD()
        {

            MostrarInformacion();        
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string info = $"Es un Animal de Hogar: {EsDeCasa}";
            Extremidades();
            ImprimirH(ImprimirPer);
            ImprimirP();
            return info;
            

        }
    }
}
