﻿using System;
namespace ArreglosU1_Repaso
{
    class program
    {
        static void Main(string[] args)
        {
            Arreglos arreglo = new Arreglos();

<<<<<<< HEAD
            //Insertar en la posición deseada
            for (int i = 0; i < 2; i++)
            {
                string nombre;
                bool esNombreValido;
                do
                {
                    Console.WriteLine("Ingrese el nombre de la persona:");
                    nombre = Console.ReadLine();
                    esNombreValido = !nombre.Any(char.IsDigit); // Verifica que no contenga números
                    if (!esNombreValido)
                    {
                        Console.WriteLine("El nombre solo debe contener letras");
                    }
                } while (!esNombreValido);
                int edad;
                bool esEdadValida;
                do
                {
                    Console.WriteLine("Ingrese la edad de la persona:");
                    string Edad = Console.ReadLine();
                    esEdadValida = int.TryParse(Edad, out edad); // Verifica que sea un número entero
                    if (!esEdadValida)
                    {
                        Console.WriteLine("La edad debe ser un número. Inténtelo de nuevo.");
                    }
                } while (!esEdadValida);
                Persona insertarPersona = new Persona(nombre, edad);
                int posicion;
                bool esnumero;
                do
                {
                    Console.WriteLine("Ingrese la posición en la que desea insertar los datos del 0 al 4:");
                    string posicionInsercion = Console.ReadLine();
                    esnumero = int.TryParse(posicionInsercion, out posicion);
                    if (!esnumero)
                    {
                        Console.WriteLine("El formato es incorrecto");
                    }
                } while (!esnumero);
                arreglo.InsertarEnPosicion(posicion, insertarPersona);


                //Modificar posicion o valor
                int modificar;
                bool esnumero2;
                do
                {
                    Console.WriteLine("Ingresa una posicion que deseas modificar");
                    string modificar2 = Console.ReadLine();
                    esnumero2 = int.TryParse(modificar2 , out modificar);
                    if(!esnumero2)
                    {
                        Console.WriteLine("El formato no es correcto");
                    }
                }while(!esnumero2);

=======
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Ingrese el nombre de la persona:");
                string nombre = Console.ReadLine();

                for (int z = 0; z < nombre.Length; i++)
                {
                    if (!Char.IsLetter(nombre[i]))
                    {
                        Console.WriteLine("El nombre solo puede contener letras.");
                        return;
                    }
                }



                Console.WriteLine("Ingrese la edad de la persona");
                    int edad = Convert.ToInt32(Console.ReadLine());

                    Persona insertarPersona = new Persona(nombre, edad);

                    Console.WriteLine("Ingrese la posición en la que desea insertar los datos entre 0 y 4:");
                    int posicionInsercion = Convert.ToInt32(Console.ReadLine());

                    arreglo.InsertarEnPosicion(posicionInsercion, insertarPersona);
                
               

             
                arreglo.MostrarDatos();
>>>>>>> refs/remotes/origin/mySuperBranch

                string nuevo;
                bool esvalido;
                do
                {
                    Console.WriteLine("Ingresa el nombre");
                    nuevo = Console.ReadLine();
                    esvalido = !nuevo.Any(char.IsDigit);
                    if (!esvalido)
                    {
                        Console.WriteLine("El formato es incorrecto");
                    }
                   
                }while(!esvalido);

                int edad2;
                bool es;
                do
                {
                    Console.WriteLine("Ingresa la edad");
                    string Nuevo = Console.ReadLine();
                    es = int.TryParse (Nuevo, out edad2);
                    if (!es)
                    {
                        Console.WriteLine("El formato es incorrecto");
                    }
                }while(!es);
          
                   Persona insertarpersona = new Persona(nuevo, edad2);
                 arreglo.ModificarPosicion(modificar, insertarpersona);
                  arreglo.MostrarDatos();


                //Buscar Nombre
                string nombre2;
                bool esNombre;
                do
                {
                    Console.WriteLine("Ingrese un nombre a buscar");
                    nombre2 = Console.ReadLine();
                    esNombre = !nombre2.Any(char.IsDigit);
                    if(!esNombre)
                    {
                        Console.WriteLine("El formato es incorrecto");
                    }
                }while(!esNombre);
                arreglo.BuscarPorNombre(nombre2);

<<<<<<< HEAD
=======
                Console.WriteLine("Ingresa una posicion que deseas modificar entre el 0 y 4");
                int modificar = Convert.ToInt32(Console.ReadLine());
>>>>>>> refs/remotes/origin/mySuperBranch

                //Eliminar una posicion;
                int eliminar2;
                bool esEliminar;
                do
                {
                    Console.WriteLine("Ingresa una posición ha eliminar");
                    string eliminar = Console.ReadLine();
                    esEliminar = int.TryParse(eliminar, out eliminar2);
                    if (!esEliminar)
                    {
                        Console.WriteLine("Ingrese el formato correcto");
                    }

<<<<<<< HEAD
                } while (!esEliminar);
=======
                Persona insertarpersona = new Persona(nuevo , edad2);

                arreglo.ModificarPosicion(modificar,insertarpersona);

                arreglo.MostrarDatos();
                //arreglo.OrdenarEdadesDescendente();
                Console.WriteLine("Ingresa una posición ha eliminar");
                int eliminar = Convert.ToInt32(Console.ReadLine());

                arreglo.EliminarPosicion(eliminar);

                arreglo.MostrarDatos();
>>>>>>> refs/remotes/origin/mySuperBranch
 
                arreglo.EliminarPosicion(eliminar2);
                arreglo.MostrarDatos();
                arreglo.OrdenarEdadDescendente();
                arreglo.MostrarDatos(); 

            }
        }
    }
}
