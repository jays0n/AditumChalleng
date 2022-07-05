using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration.Attributes;
using System.ComponentModel.DataAnnotations;
using CsvHelper.Configuration;

namespace ADITUM.CHALLENGE
{
    public class Restaurante
    {   

        [Name("RestaurantName")]
        public string RestauranteName { get; set; }

        [Name("OpenHours")]
        public string RestauranteIntervalo { get; set; }
    }
 
}
