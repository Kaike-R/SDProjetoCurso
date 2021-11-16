using System;

namespace SistemasDistribuidos.Models
{
    public sealed class TanqueDeOleo
    {

        private static TanqueDeOleo _instance;
        public static TanqueDeOleo getInstance()
        {
            if(_instance == null)
            {
                _instance = new TanqueDeOleo();
            }
            return _instance;
        }
        public double Volume{get;set;} 
    }
}