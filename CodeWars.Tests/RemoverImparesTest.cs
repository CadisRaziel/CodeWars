using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    public class RemoverImparesTest
    {
        [Theory(DisplayName = "Deve remover os numeros pares.")]
        [InlineData(new int[] { 1, 2, 2, 2, 4, 3, 4, 5, 6, 7 }, new int[] { 1,3,5,7 })]
        public void remover_pares(int[] input, int[] esperado)
        {
            //Importante!!
            //O inlineData nao aceita LISTAS !!!
            //Então eu passo como array e depois transformo em lista !!!

            var listOfNumbers = input.ToList();
            var esperadoList = esperado.ToList();

            var resultado = RemoverImpares.FilterOddNumber(listOfNumbers);

            Assert.Equal(esperadoList, resultado);
        }
    }
}
