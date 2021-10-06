using LabSegundaParte.Entidades;
using LabSegundaParte.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSegundaParte
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsPersona persona = new ClsPersona();
            NClsPersona nclspersona = new NClsPersona();

            Console.WriteLine("Ingresa tu nombre");
            String nombre = Console.ReadLine();
            Console.WriteLine("Escribe tu edad");
            int edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su sexo");
            string sexo = Console.ReadLine();     
            Console.WriteLine("Ingrese su peso");
            double peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa tu altura");
            double altura = Convert.ToDouble(Console.ReadLine());


            ClsPersona constructor = new ClsPersona(nombre, edad, sexo, peso, altura);
            ClsPersona constructor1 = new ClsPersona(nombre, edad, sexo);

            Console.WriteLine(nclspersona.calcularIMc(constructor));
            Console.WriteLine(nclspersona.esMayorDeEdad(constructor));

            Console.WriteLine(constructor.ToString());
            Console.ReadLine();


        }
    }
}
