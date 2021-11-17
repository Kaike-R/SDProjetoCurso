using System;

namespace SistemasDistribuidos.Models
{
    public sealed class ReatorNAOH
    {

        private static ReatorNAOH _instance;
        public static ReatorNAOH getInstance()
        {
            if(_instance == null)
            {
                _instance = new ReatorNAOH();
            }
            return _instance;
        }
        public double Volume{get;set;} 
    }
}