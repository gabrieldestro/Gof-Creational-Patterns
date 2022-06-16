using System;

namespace Exercicio1
{
    public sealed class Logger
    {
        private static readonly Logger _Logger = new Logger();
        private Logger()
        {}
        public static Logger GetLogger
        {
            get 
            {
                return _Logger;
            }
        }
        public void Registrar(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}
