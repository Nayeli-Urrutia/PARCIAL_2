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

        //interface
        public override void Extremidades()
        {
            Console.WriteLine("El Tiburon Blanco tiene Aletas.");
        }
        public string MostrarInformacionAC()
        {
            // Poliformismo
            MostrarInformacion();
           
            Console.ForegroundColor = ConsoleColor.Red;
            string ani = $"Es un Animal Depredador: {EsDepredador}";            
            Extremidades();
            Console.ResetColor();

            return ani;

        }
    }
}
