using System;

namespace SistemasDistribuidos.Models
{
    public sealed class TanqueGlicerina
    {

        private static TanqueGlicerina _instance;
        public static TanqueGlicerina getInstance()
        {
            if(_instance == null)
            {
                _instance = new TanqueGlicerina();
            }
            return _instance;
        }
        public double Volume{get;set;} 
    }
}