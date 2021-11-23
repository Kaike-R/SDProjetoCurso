using System;

namespace SistemasDistribuidos.Models
{
    public sealed class ReatorETOH
    {

        private static ReatorETOH _instance;
        public static ReatorETOH getInstance()
        {
            if(_instance == null)
            {
                _instance = new ReatorETOH();
            }
            return _instance;
        }
        public double Volume{get;set;} 
    }
}