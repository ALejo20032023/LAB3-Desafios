using System;

class Program
{
    static char[,] tablero = new char[3, 3];
    static char jugadorActual = 'X';
    static bool juegoTerminado = false;

    static void Main(string[] args)
    {
        InicializarTablero();
        while (!juegoTerminado)
        {
            DibujarTablero();
            PedirJugada();
            VerificarGanador();
            CambiarTurno();
        }
    }

    static void InicializarTablero()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                tablero[i, j] = ' ';
            }
        }
    }

    static void DibujarTablero()
    {
        Console.Clear();
        Console.WriteLine("   0  1  2");
        Console.WriteLine("0  " + tablero[0, 0] + " | " + tablero[0, 1] + " | " + tablero[0, 2]);
        Console.WriteLine("  -----------");
        Console.WriteLine("1  " + tablero[1, 0] + " | " + tablero[1, 1] + " | " + tablero[1, 2]);
        Console.WriteLine("  -----------");
        Console.WriteLine("2  " + tablero[2, 0] + "
