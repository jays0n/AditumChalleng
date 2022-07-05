using System;
using System.Collections.Generic;
using System.Text;
using ADITUM.CHALLENGE.Controllers;
using Xunit;
using System.Text.Json;

namespace ADITUM.CHALLENGE.TESTE
{
    public class RestauranteControllerTeste
    {
        
        [Theory]
        [InlineData("12:00",9)]
        /*[InlineData("10:00", 2)]
        [InlineData("08:50", 0)]
        [InlineData("21:30", 5)]
        [InlineData("22:40", 2)]
        [InlineData("00:00", 0)]*/
        public void GetRestaurante_return_length_json(string refHour,int quantity)
        {
            //Arrange
            var clsRestController = new RestauranteController();
            string jsonString = clsRestController.GetRestaurante(refHour);
            var clsRestauranteList = JsonSerializer.Deserialize<List<Restaurante>>(jsonString);
            int _return;
            //Action
            if (clsRestauranteList != null)
            {
                _return = clsRestauranteList.Count;

            }
            else
            {
                _return = 0;
            }
            

            //Assert
            Assert.Equal(quantity, _return);
        }

        
    }
}
