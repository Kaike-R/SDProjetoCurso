using System;

namespace SistemasDistribuidos.Models
{
    public sealed class TanqueDeBiodisel
    {

        private static TanqueDeBiodisel _instance;
        public static TanqueDeBiodisel getInstance()
        {
            if(_instance == null)
            {
                _instance = new TanqueDeBiodisel();
            }
            return _instance;
        }
        public double Volume{get;set;} 
    }
}