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
        public void EliminarEnPosicion(int posicion)
        {
            if (posicion < 0 || posicion >= persona.Length)
            {
                Console.WriteLine("Posición inválida. Debe estar entre 0 y 9.");
                return;
            }

            Console.WriteLine($"Se ha eliminado el valor '{persona[posicion]}' en la posición {posicion}.");
            persona[posicion] = null; // Puedes asignar null u otro valor predeterminado según tus necesidades.
        }
        public void ModificarEnPosicion(int posicion, string nuevoValor)
        {
            if (posicion < 0 || posicion >= persona.Length)
            {
                Console.WriteLine("Posición inválida. Debe estar entre 0 y 9.");
                return;
            }

            Console.WriteLine($"Se ha modificado el valor en la posición {posicion}. Antiguo valor: {persona[posicion]}, Nuevo valor: {nuevoValor}.");
            persona[posicion] = nuevoValor;
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
