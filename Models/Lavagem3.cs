using System;

namespace SistemasDistribuidos.Models
{
    public sealed class Lavagem3
    {

        private static Lavagem3 _instance;
        public static Lavagem3 getInstance()
        {
            if(_instance == null)
            {
                _instance = new Lavagem3();
            }
            return _instance;
        }
        public double Volume{get;set;} 
    }
}