using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosU1_Repaso
{
    public class Arreglos
    {
        //como crear una matriz
        string[] persona = new string[10];

        public void InsertarEnPosicion(int posicion, string valor)
        {
            if (posicion < 0 || posicion >= persona.Length)
            {
                Console.WriteLine("Posición inválida. Debe estar entre 0 y 9.");
                return;
            }

            persona[posicion] = valor;

            Console.WriteLine($"El valor '{valor}' se ha insertado correctamente en la posición {posicion}.");
        }

        public void MostrarDatosIngresados()
        {
            Console.WriteLine("\nDatos ingresados:");

            for (int i = 0; i < persona.Length; i++)
            {
                Console.WriteLine($"Posición {i}: {persona[i]}");
            }
        }

    }
}
