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
        Persona[] persona = new Persona[3];
        public void InsertarEnPosicion(int posicion, Persona valor)
        {
            if (posicion < - 1 || posicion >= persona.Length)
            {
                Console.WriteLine("Posición inválida. Debe estar entre 0 y 9.");
                return;
            }

            persona[posicion - 1] = valor;

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
            if (posicion < 0 || posicion >= persona.Length) 
            {
                Console.WriteLine("Posición invalida");
                return ;
            }
            
            Console.WriteLine($"El valor {persona[posicion]} se ha eliminado en la posición {posicion}");
            persona[posicion - 1] = null;
        }
        public void ModificarPosicion(int posicion, Persona nuevoDato)
        {
            if (posicion < - 1  || posicion >= persona.Length)
            {
                Console.WriteLine("Posición invalida");
            }
            persona[posicion - 1] = nuevoDato;
            Console.WriteLine($"El nuevo valor {nuevoDato.Nombre}, Edad: {nuevoDato.Edad} se ha modificado en la posición {posicion}");
        }
        public void MostrarDatos()
        {
            Console.WriteLine("Los datos ingresados son");
            for(int i = 0; i < persona.Length; i++)
            {
                Console.WriteLine($"Posición: {persona [i] }");
            }
        }
        public void OrdenarEdadesDescendente()
        {
            // Filtrar elementos no nulos y ordenar por edad de manera descendente
            var edadesOrdenadas = persona
                .Where(p => p != null)
                .OrderByDescending(p => p.Edad)
                .ToArray();

            // Reemplazar el arreglo original con el arreglo ordenado
            Array.Copy(edadesOrdenadas, persona, edadesOrdenadas.Length);

            Console.WriteLine("Edades ordenadas de manera descendente:");
            MostrarDatos(); // Puedes ajustar este método según tus necesidades
        }

    }
}
