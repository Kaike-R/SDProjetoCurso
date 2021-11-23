using System;

namespace SistemasDistribuidos.Models
{
    public sealed class Decantador
    {

        private static Decantador _instance;
        public static Decantador getInstance()
        {
            if(_instance == null)
            {
                _instance = new Decantador();
            }
            return _instance;
        }
        public double Volume{get;set;} 
    }
}