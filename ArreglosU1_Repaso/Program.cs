using System;
namespace ArreglosU1_Repaso
{
    class program
    {
        static void Main(string[] args)
        {
            Arreglos arreglo = new Arreglos();

            arreglo.InsertarEnPosicion(0, "Persona1");
            arreglo.InsertarEnPosicion(1, "Persona2");
            arreglo.InsertarEnPosicion(2, "Persona3");

            // Mostrar datos ingresados
            arreglo.MostrarDatosIngresados();

            // Modificar elemento en la posición 1
            arreglo.ModificarEnPosicion(1, "NuevaPersona2");

            // Eliminar elemento en la posición 0
            arreglo.EliminarEnPosicion(0);

            // Mostrar datos después de las operaciones
            arreglo.MostrarDatosIngresados();

            Console.ReadLine(); // Para 






            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Ingrese un valor:");
            //    string valor = Console.ReadLine();

            //    Console.WriteLine("Ingrese la posición del 0 al 9:");
            //    int posicion = Convert.ToInt32(Console.ReadLine());

            //    persona.InsertarEnPosicion(posicion, valor);
            //}

            // Mostrar los datos ingresados en la matriz
            //persona.MostrarDatosIngresados();

            Console.ReadKey();
        }
    }
}
