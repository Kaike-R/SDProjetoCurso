using System;

namespace SistemasDistribuidos.Models
{
    public sealed class Reator
    {

        private static Reator _instance;
        public static Reator getInstance()
        {
            if(_instance == null)
            {
                _instance = new Reator();
            }
            return _instance;
        }
        public double Volume{get;set;}
        public double Oleo {get;set;}
        public double Eaoh {get;set;}
        public double Naoh {get;set;}
        public double Mistura{get;set;}
    }
}