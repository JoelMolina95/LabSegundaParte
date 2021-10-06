using LabSegundaParte.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSegundaParte.Negocio
{
    class NClsPersona
    {

        public string calcularIMc(ClsPersona constructor)
        {
            double pro;
            pro = (constructor.Peso / Math.Pow(constructor.Altura, 2));

            if (pro <= 20)
            {
                return "Peso ideal";
            }
            if (pro >=21)
            {
                return "Tienen sobre peso";
            }
            return "";
        }
        public string esMayorDeEdad(ClsPersona constructor)
        {
            if (constructor.Edad >= 18)
            {
                return "Es mayor de Edad";
            }
            else
            {
                return "Es menor de edad";
            }
        }
    }
}
