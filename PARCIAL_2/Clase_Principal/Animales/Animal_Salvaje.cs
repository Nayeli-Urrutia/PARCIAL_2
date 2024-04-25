using PARCIAL_2.Clase_Principal.Animales;
using PARCIAL_2.parcial_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL_2.Clase_Principal.Clase_Animales
{
    internal class Animal_Salvaje : Clases_de_Animales
    {
        public bool EsManada { get; set; }

        // Interface
        public override void Extremidades()
        {
            Console.WriteLine("El León tiene 4 patas.");
        }

        // Delegado
        public void ImprimirH(ImprimirHDelegate imprimirDelegate)
        {
            imprimirDelegate();
        }

        public void ImprimirL()
        {
            Console.WriteLine("Nombre Cientifico: Panthera leo");
        }

        // Declaración del evento basado en el delegado
        public event ImprimirHDelegate LeonImpreso;

        public void ImprimirLE()
        {
            // Verificar si hay suscriptores al evento
            if (LeonImpreso != null)
            {

                LeonImpreso();
            }
        }

        public string MostrarInformacionAS()
        {
            // Polimorfismo
            MostrarInformacion();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string info = $"Es un Animal que caza en Manada: {EsManada}";
            Extremidades();
            ImprimirH(ImprimirL);
            ImprimirLE();

            return info;
          
        }

    }
    }
