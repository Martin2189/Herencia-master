using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class ballena : Mamifero
    {
        private string raza;
        public ballena(string n, double p, string d) : base(n, p)
        {
            this.raza = d;
        }   

        public void balle()
        {
            string nom = "";
            nom = getNombre();
            Console.WriteLine("el nombre de la ballena es de: "+nom);
            Console.WriteLine("el peso es de: " + peso);
            Console.WriteLine("la raza es: " + raza);
        }
    }
}
