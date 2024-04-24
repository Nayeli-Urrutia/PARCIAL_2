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
        
        //interface
        public override void Extremidades()
        {
            Console.WriteLine("El Leon tiene 4 patas.");
        }

        public string MostrarInformacionAS()
        {
            // Poliformismo
            MostrarInformacion();
            Console.ForegroundColor = ConsoleColor.Red;
            string leo= $"Es un Animal que caza en Manada: {EsManada}";
            Extremidades();
            Console.ResetColor();

            return leo;

            
        }
    }
}