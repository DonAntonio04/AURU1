﻿using System;
namespace ArreglosU1_Repaso
{
    class program
    {
        static void Main(string[] args)
        {
            Arreglos arreglo = new Arreglos();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ingrese el nombre de la persona:");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la edad de la persona");
                int edad = Convert.ToInt32(Console.ReadLine());

               Persona insertarPersona = new Persona(nombre, edad);

                Console.WriteLine("Ingrese la posición en la que desea insertar los datos:");
                int posicionInsercion = Convert.ToInt32(Console.ReadLine());

                arreglo.InsertarEnPosicion(posicionInsercion, insertarPersona);
                arreglo.MostrarDatos();

                Console.WriteLine("Ingrese un nombre a buscar");
                string nombre2 = Console.ReadLine();

                arreglo.BuscarPorNombre(nombre2);
           

                Console.WriteLine("Ingresa una posicion que deseas modificar");
                int modificar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingresa el nombre");
                string nuevo = Console.ReadLine();
                Console.WriteLine("Ingresa la edad");
                int edad2 = Convert.ToInt32(Console.ReadLine());    

                Persona insertarpersona = new Persona(nuevo , edad2);

                arreglo.ModificarPosicion(modificar,insertarpersona);

                arreglo.MostrarDatos();
                arreglo.OrdenarEdadesDescendente();
                Console.WriteLine("Ingresa una posición ha eliminar");
                int eliminar = Convert.ToInt32(Console.ReadLine());

                arreglo.EliminarPosicion(eliminar);

                arreglo.MostrarDatos();
 

            }
        }
    }
}
