using System;

namespace SistemasDistribuidos.Models
{
    public sealed class Lavagem
    {

        private static Lavagem _instance;
        public static Lavagem getInstance()
        {
            if(_instance == null)
            {
                _instance = new Lavagem();
            }
            return _instance;
        }
        public double Volume{get;set;} 
    }
}