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
        Persona[] persona = new Persona[5];
        public void InsertarEnPosicion(int posicion, Persona valor)
        {
            if (posicion < -1 || posicion >= persona.Length)
            {
                Console.WriteLine("Posición inválida. Debe estar entre 0 y 4.");
                return;
            }

            persona[posicion] = valor;

            Console.WriteLine($"El nombre {valor.Nombre} y edad {valor.Edad}  se ha insertado correctamente en la posición {posicion}.");
        }
          public Persona BuscarPorNombre(string nombreBuscado)
        {
            for (int i = 0; i < persona.Length; i++)
            {
                if (persona[i] != null && persona[i].Nombre.Equals(nombreBuscado))
                {
                    Console.WriteLine($"La persona con el nombre '{nombreBuscado}' se encuentra en la posición {i}.");
                    return persona[i];
                }
            }

            Console.WriteLine($"La persona con el nombre '{nombreBuscado}' no se encuentra");
            return null;
        }
        public void EliminarPosicion(int posicion)
        {
            if (posicion < -1 || posicion >= persona.Length) 
            {
                Console.WriteLine("Posición invalida");
                return ;
            }
            
            Console.WriteLine($"El valor {persona[posicion]} se ha eliminado en la posición {posicion}");
            persona[posicion] = null;
        }
        public void ModificarPosicion(int posicion, Persona nuevoDato)
        {
            if (posicion < - 1  || posicion >= persona.Length)
            {
                Console.WriteLine("Posición invalida");
            }
            persona[posicion] = nuevoDato;
            Console.WriteLine($"El nuevo valor {nuevoDato.Nombre}, Edad: {nuevoDato.Edad} se ha modificado en la posición {posicion}");
        }
        public void MostrarDatos()
        {
            Console.WriteLine("Los datos ingresados son");
            for(int i = 0; i < persona.Length; i++)
            {
                Console.WriteLine($"Posición {i}: {persona [i] }");
            }
        }

        public void OrdenarEdadDescendente()
        {
            for (int i = 0; i < persona.Length - 1; i++)
            {
                for (int j = 0; j < persona.Length - i - 1; j++)
                {
                    if (persona[j]?.Edad < persona[j + 1]?.Edad)
                    {
                        // Intercambiar las posiciones si la edad es mayor
                        Persona temp = persona[j];
                        persona[j] = persona[j + 1];
                        persona[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Las edades se han ordenado de forma descendente");
            MostrarDatos(); // Muestra los datos ordenados
        }
    }
}
