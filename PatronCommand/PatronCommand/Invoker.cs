using System;
using System.Collections.Generic;
using System.Text;

namespace PatronCommand
{
    public class Invoker
    {
        private ICommand command;
        private List<ICommand> comandos;

        public Invoker()
        {
            comandos= new List<ICommand>();
            comandos.Add(new CaminarCommand());
            comandos.Add(new CorrerCommand());
            comandos.Add(new SaltarCommand());
            comandos.Add(new GolpearCommand());
         }

        public void mostrarComandos(IGuerrero guerrero)
        {
            bool flag = false;
            bool inicio=true;

            do
            {
                if (inicio)
                {
                    Console.Clear(); //Limpiar la pantalla
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Seleccione comandos...");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[A] Caminar [B] Correr [D] Saltar [F] Golpear [Esc] Salir\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                

                ConsoleKeyInfo op = Console.ReadKey(true);

                
                    ICommand comando= getCommando(op.Key);
                    if(comando!=null)comando.Execute(guerrero);

                    if (op.Key.Equals(ConsoleKey.Escape))
                        flag = true;

                inicio = false;
            } while (!flag);
        }
        
        private ICommand getCommando(ConsoleKey clave)
        {
            ICommand comando=null;
            switch (clave)
            {
                case ConsoleKey.A:
                    comando = new CaminarCommand();
                    break;
                case ConsoleKey.S:
                    comando = new CorrerCommand();
                    break;
                case ConsoleKey.D:
                    comando = new SaltarCommand();
                    break;
                case ConsoleKey.F:
                    comando = new GolpearCommand();
                    break;
            }
            return comando;
        }
    }
}
