using System;

namespace SistemasDistribuidos.Models
{
    public sealed class Secador
    {

        private static Secador _instance;
        public static Secador getInstance()
        {
            if(_instance == null)
            {
                _instance = new Secador();
            }
            return _instance;
        }
        public double Volume{get;set;} 
    }
}