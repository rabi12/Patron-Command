using System;
using System.Collections.Generic;
using System.Text;

namespace PatronCommand
{
    class Juego
    {
        public void MostrarMenuInicio()
        {
            bool flag = false;
            do
            {
                Console.Clear(); //Limpiar la pantalla
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Seleccione una opcion...");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[A] Jugar");
                Console.WriteLine("[Esc] Salir\n");
                Console.ForegroundColor = ConsoleColor.White;

                ConsoleKeyInfo op = Console.ReadKey(true);

                switch (op.Key)
                {
                    case ConsoleKey.A:
                        Console.WriteLine("Ud seleccionó la opción Jugar");

                        Jugar();

                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.Escape:
                        flag = true;

                        break;
                }
            } while (!flag);
        }

        private void Jugar()
        {
            IGuerrero guerrero=elegirTipoGuerrero();
            if (guerrero == null) return;

            guerrero.setNombre(solicitarNombreJugador());
            Invoker invocadorComandos = new Invoker();
            invocadorComandos.mostrarComandos(guerrero);
        }

        private IGuerrero elegirTipoGuerrero()
        {
            IGuerreroFactory guerreros = new GuerreroFactory();
            IGuerrero jugador = null;

            Console.Clear(); //Limpiar la pantalla
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Elija la clase de Guerrero...");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[B] Clase Baja [M] Clase Media [A] Clase Alta [Esc] Salir\n");
            Console.ForegroundColor = ConsoleColor.White;
            ConsoleKeyInfo op = Console.ReadKey(true);
                
            switch (op.Key)
            {
                case ConsoleKey.A:
                    Console.WriteLine("Ud seleccionó Guerrero Clase Alta");
                    jugador = guerreros.crearGuerrero("A");
                    break;
                case ConsoleKey.M:
                    Console.WriteLine("Ud seleccionó Guerrero Clase Media");
                    jugador = guerreros.crearGuerrero("M");
                    break;
                case ConsoleKey.Escape:
                    jugador = null;
                    break;
                default:
                    Console.WriteLine("Ud seleccionó Guerrero Clase Baja");
                    jugador = guerreros.crearGuerrero("B");
                    break;
            }
            
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
            return jugador;
        }

        private string solicitarNombreJugador()
        {
            Console.WriteLine("Ingrese el nombre del Guerrero...");
            string nombre = Console.ReadLine();
            return nombre;
        }
    }
}
