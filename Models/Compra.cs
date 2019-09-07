using System;
using ConexionBD.models;
using System.ComponentModel.DataAnnotations;

namespace ConexionBD.models
{

    public class invoice{
        

        public int id {get;set;}

        public String Cliente {get; set;}
        
        public String Producto {get; set;}

        [DataType(DataType.Date)]
        public DateTime date {get; set;}

        public String cantidad {get; set;}

        public String SubTotal {get; set;}

        public String total {get; set;}

        public String random {get; set;}
        
    }

}