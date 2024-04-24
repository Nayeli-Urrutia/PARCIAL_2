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

        public string MostrarInformacionAD()
        {

            MostrarInformacion();        
            Console.ForegroundColor = ConsoleColor.Red;
            string info = $"Es un Animal de Hogar: {EsDeCasa}";
             Extremidades();
            Console.ResetColor();
           

            return info;


        }
    }
}
