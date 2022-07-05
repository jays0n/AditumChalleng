using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Helpers;
using CsvHelper;


namespace ADITUM.CHALLENGE.Base
{
    public class RestauranteContext
    {
        

        public List<Restaurante> ReadCsv(string fileName)
        {
            try
            {
                using (var reader = new StreamReader(fileName))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    csv.Context.RegisterClassMap<RestauranteMap>();
                    var records = csv.GetRecords<Restaurante>().ToList();
                    return records;
                }
            }
            catch
            {
                return null;
            }
            
        }

        public List<Restaurante> Search(string fileName,TimeSpan refHour)
        {
            var csvRecords = ReadCsv(fileName);
            if (csvRecords != null)
            {
                var _return = new List<Restaurante>();
                foreach (var it in csvRecords)
                {
                    TimeSpan hhAbre, hhFecha;

                    hhAbre = TimeSpan.Parse(it.RestauranteIntervalo.Split("-")[0].Trim());
                    hhFecha = TimeSpan.Parse(it.RestauranteIntervalo.Split("-")[1].Trim());

                    if (TimeSpan.Compare(hhAbre, refHour) < 1 && TimeSpan.Compare(hhFecha, refHour) > -1)
                    {
                        _return.Add(new Restaurante()
                        {
                            RestauranteIntervalo = it.RestauranteIntervalo,
                            RestauranteName = it.RestauranteName
                        }
                        );
                    }
                }
                return _return;
            }
            return null;
        }




    }
}
