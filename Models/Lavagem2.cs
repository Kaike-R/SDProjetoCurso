using System;

namespace SistemasDistribuidos.Models
{
    public sealed class Lavagem2
    {

        private static Lavagem2 _instance;
        public static Lavagem2 getInstance()
        {
            if(_instance == null)
            {
                _instance = new Lavagem2();
            }
            return _instance;
        }
        public double Volume{get;set;} 
    }
}