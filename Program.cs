using PryCafeteria.Clases;

namespace PryCafeteria
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int x = 0; x < 3; x++)
            {

                Console.WriteLine("ingresa el nombre de la bebida: ");
                string nombreBebida = Console.ReadLine();
                Console.WriteLine("ingresa el tamaño de la bebida: ");
                string tamanio = Console.ReadLine();
                Console.WriteLine("ingresa el precio de la bebida: ");
                float precio = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el porcentaje de descuento si aplica:");
                float porcentaje = float.Parse(Console.ReadLine());

                Bebida bebida1 = new Bebida(nombreBebida, tamanio, precio);

                bebida1.aplicarDescuento(porcentaje);
                Console.WriteLine("\n"+bebida1.preparar());
                Console.WriteLine(bebida1.mostrarDescripcion()+"\n");

            }

        }
    }
}
