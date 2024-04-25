using PARCIAL_2.Clase_Principal.Animales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PARCIAL_2.parcial_2
{
    internal class Clases_de_Animales : IAnimal
     
    {
        private Animal_Domestico[] disponibles;
       
        public Animal_Domestico this [int indice]
        {
            get { return disponibles[indice];}
            set { disponibles[indice] = value;}
        }

        // Delegado 
        public delegate void ImprimirHDelegate();

        //interface
        public virtual void Extremidades()
        {
            Console.WriteLine("El animal emite un sonido.");
        }
    
    
        //1. ABSTRACCION
        private string nombre;
        private string habitat;
        private string alimentacion;
        private string reproduccion;
        private string emitir_sonido;
        private int numero_crias;



        //2. Encapsulacion
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Habitat
        {
            get { return habitat; }
            set { habitat = value; }
        }

        public string Alimentacion
        {
            get { return alimentacion; }
            set { alimentacion = value; }
        }
        public string Reproduccion
        {
            get { return reproduccion; }
            set { reproduccion = value; }
        }
        public int Numero_crias
        {
            get { return numero_crias; }
            set { numero_crias = value; }
        }
        public string Emitir_sonido
        {
            get { return emitir_sonido; }
            set { emitir_sonido = value; }
        }

        // 3. Polimorfismo
        public void MostrarInformacion()
        {



            Console.WriteLine($"Nombre:       {Nombre}");
            Console.WriteLine($"Habitat:      {Habitat}");
            Console.WriteLine($"Alimentacion: {Alimentacion}");
            Console.WriteLine($"Reproducción: {Reproduccion}");
            Console.WriteLine($"{Nombre} puede tener hasta {Numero_crias} crias ");
            Console.WriteLine($"El sonido que emite {Nombre} es {Emitir_sonido}");

          



        }

    }
}


    



    

