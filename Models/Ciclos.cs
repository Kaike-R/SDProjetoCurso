using System;

namespace SistemasDistribuidos.Models
{
    public sealed class Ciclos
    {

        private static Ciclos _instance;
        public static Ciclos getInstance()
        {
            if(_instance == null)
            {
                _instance = new Ciclos();
            }
            return _instance;
        }
        public int ciclos{get;set;} 
    }
}