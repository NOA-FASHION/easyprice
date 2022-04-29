using System;
using System.Collections.Generic;

namespace easyprice
{
    public class deviseclassCurrencyFreacks
    {
    
        public bool Success { get; set; }

      
        public long Timestamp { get; set; }

 
        public string Base { get; set; }

        public DateTimeOffset Date { get; set; }

      
        public Dictionary<string, double> Rates { get; set; }
        public deviseclassCurrencyFreacks()
        {
        }
    }
}
