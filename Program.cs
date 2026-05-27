using PryCafeteria.Clases;

namespace PryCafeteria
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float costoTotal = 0;

            Bebida[] pedidos = new Bebida[] {
                new BebidaCaliente("Café con leche","grande",90,89),
                new BebidaFria("Frape chocolate","pequeño", 80, 2),
                new BebidaFria("Frapuchino", "grande",80,3),
                new BebidaCaliente("Expreso","pequeño",70,80),
                new BebidaCaliente("Té de canela","chico",60,89 )
            };

            for (int x = 0; x < pedidos.Length; x++)
            {
                Bebida bebida = pedidos[x];

                if (bebida is BebidaCaliente caliente)
                {
                    if (caliente._temperatura > 88)
                        Console.WriteLine("[!] ADVERTENCIA: ¡Cuidado, bebida muy caliente!");
                    Console.WriteLine(pedidos[x].preparar() + "\n");
                }
                else {
                    Console.WriteLine(pedidos[x].preparar() + "\n");
                }

                costoTotal = costoTotal + pedidos[x]._precio;
                
            }

            Console.WriteLine($"\nEl costo total de los pedidos es: ${costoTotal}");

        }
    }
}
