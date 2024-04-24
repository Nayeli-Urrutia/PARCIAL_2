using PARCIAL_2.Clase_Principal.Animales;
using PARCIAL_2.Clase_Principal.Clase_Animales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL_2
{
    internal class Program
    {

        static void Main(string[] args)
        {
           
            {
                //ANIMAL ACUATICO
                Console.ForegroundColor = ConsoleColor.Blue;
                Animal_Acuatico AC = new Animal_Acuatico();
                Console.WriteLine("******************************************************");
                Console.ResetColor();
                AC.Nombre        = "Tiburon Blanco";
                AC.Habitat       = "En el Mar";
                AC.Alimentacion  = "Carnivoro ";
                AC.Reproduccion  = "Ovipara";
                AC.Numero_crias  = 14;
                AC.EsDepredador  = true;
                AC.Emitir_sonido = "Silencioso";
             

                string resultado = AC.MostrarInformacionAC();
                Console.WriteLine(resultado);
                Console.WriteLine("");

                //ANIMAL SALVAJE
                Console.ForegroundColor = ConsoleColor.Blue;
                Animal_Salvaje AS = new Animal_Salvaje();
                Console.WriteLine("******************************************************");
                Console.ResetColor();
                AS.Nombre           = "Leon";
                AS.Habitat          = "En la Selva";
                AS.Alimentacion     = "Carnivoro ";
                AS.Reproduccion     = "Viviparo";
                AS.Numero_crias     = 6;
                AS.Emitir_sonido = "¡GRRRAAAUUU!";
                AS.EsManada = true;

                string resultado2 = AS.MostrarInformacionAS();
                Console.WriteLine(resultado2);
                Console.WriteLine("");

                //ANIMAL DOMESTICO
                Console.ForegroundColor = ConsoleColor.Blue;
                Animal_Domestico AD = new Animal_Domestico ();
                Console.WriteLine("******************************************************");
                Console.ResetColor();
                AD.Nombre         = "Perro";
                AD.Habitat        = "En en Hogar";
                AD.Alimentacion   = "Carnivoro ";
                AD.Reproduccion   = "Viviparo";
                AD.Numero_crias   = 8;
                AD.Emitir_sonido  = "¡GUAUAU!";
                AD.EsDeCasa       = true;
                string resultado3 = AD.MostrarInformacionAD();
                Console.WriteLine(resultado3);
            }

            {


            }

            
            Console.ReadKey();
        }
    }
}
