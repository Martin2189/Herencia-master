using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class vaca : Mamifero
    {
        //atributos
        private double litros { get; set; }


        public vaca(string n, double p, double c) : base(n,p)
        {
            this.litros = c;
        }


        public void muu()
        {   
            double comida;
            string nom = "";
            nom = getNombre();
            Console.WriteLine("el nombre es: " + nom);
            Console.WriteLine("el peso de la vaca es de: " + peso);
            Console.WriteLine("produce la cantidad de leche de: " + litros);
            comida = peso / litros;
            Console.WriteLine("la cantidad de comida que consume la vaca es de: " + comida);
        }
    }
}
