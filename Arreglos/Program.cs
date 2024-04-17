using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] compras = {
            {50, 150, 500, 1200, 300},
            {800, 100, 2000, 300, 700},
            {1500, 600, 250, 400, 900},
            {200, 100, 300, 50, 1800},
            {500, 800, 1200, 150, 1000}
        };

        AplicarDescuentoYMostrarTotal(compras);
    }

    static void AplicarDescuentoYMostrarTotal(double[,] compras)
    {
        double[] totales = new double[compras.GetLength(0)];

        for (int i = 0; i < compras.GetLength(0); i++)
        {
            double totalCliente = 0;
            for (int j = 0; j < compras.GetLength(1); j++)
            {
                totalCliente += compras[i, j];
            }

            double descuento = 0;
            if (totalCliente >= 100 && totalCliente <= 1000)
            {
                descuento = totalCliente * 0.1;
            }
            else if (totalCliente > 1000)
            {
                descuento = totalCliente * 0.2;
            }

            totales[i] = totalCliente - descuento;

            Console.WriteLine($"Cliente {i + 1}: Total de compras = {totalCliente.ToString("C2")}, Descuento = {descuento.ToString("C2")}, Total con descuento = {totales[i].ToString("C2")}");
        }
    }
}
