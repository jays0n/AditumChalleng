using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADITUM.CHALLENGE.Base
{
    public class RestauranteMap:ClassMap<Restaurante>
    {
        public RestauranteMap()
        {
            Map(p => p.RestauranteName).Name("RestaurantName");
            Map(p => p.RestauranteIntervalo).Name("OpenHours");
        }
    }
}
