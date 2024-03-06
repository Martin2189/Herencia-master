// See https://aka.ms/new-console-template for more information

//Variables 
using Herencia;

string nombre;
double peso;
int nBigotes;
double litros;
string raza;

//Ingresar y mostrar clase gato
Console.WriteLine("------Clase gato------");
Console.Write("Ingresa el nombre del gato: ");
nombre = Console.ReadLine();

Console.Write("Ingresa el peso: "); 
peso = double.Parse(Console.ReadLine());

Console.Write("Ingresa el numero de bigotes: ");
nBigotes = int.Parse(Console.ReadLine());

//Instancia de los objetos
//Gato 
Gato gato1 = new Gato(nombre, peso, nBigotes);

Console.WriteLine(); 
gato1.mostrarGato();

//Cambiando el nombre al gato
gato1.setNombre("Lucifer");
nombre = gato1.getNombre();
Console.WriteLine("\n---Le cambie el nombre al gato----\n");
gato1.mostrarGato(); 

//ingresar y mostrar la clase vaca
Console.WriteLine("-----clase vaca-------");
Console.WriteLine("ingresa el nombre de la vaca: ");
nombre = Console.ReadLine();

Console.WriteLine("ingresa el peso de la vaca: ");
peso = double.Parse(Console.ReadLine());

Console.WriteLine("cuantos litros produce la vaca: ");
litros = double.Parse(Console.ReadLine());

//instancia de vaca
vaca vaca1 = new vaca(nombre, peso, litros);
Console.WriteLine();
vaca1.muu();

//ingresar y mostrar la clase ballena
Console.WriteLine("--------clase ballena-------");
Console.WriteLine("ingresa el nombre de la ballena: ");
nombre = Console.ReadLine();

Console.WriteLine("ingresa el peso de la ballena: ");
peso = double.Parse(Console.ReadLine());

Console.WriteLine("ingresa la raza de la ballena: ");
raza = Console.ReadLine();

//instancia de la vaca
ballena ballena1 = new ballena(nombre, peso, raza);
Console.WriteLine();
ballena1.balle();


Console.ReadKey();