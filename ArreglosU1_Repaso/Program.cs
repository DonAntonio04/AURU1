using System;
namespace ArreglosU1_Repaso
{
    class program
    {
        static void Main(string[] args)
        {
            Arreglos persona = new Arreglos();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un valor:");
                string valor = Console.ReadLine();

                Console.WriteLine("Ingrese la posición del 0 al 9:");
                int posicion = Convert.ToInt32(Console.ReadLine());

                persona.InsertarEnPosicion(posicion, valor);
            }

            // Mostrar los datos ingresados en la matriz
            persona.MostrarDatosIngresados();

            Console.ReadKey();
        }
    }
}
