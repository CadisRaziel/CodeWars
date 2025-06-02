using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    public class DecToolsTest
    {
        [Theory(DisplayName = "Deve retornar o length")]
        [InlineData(22, 2)] //Esperado
        //[InlineData(2, "abc", "abcabc")] //Testar erro
        //[InlineData(0, "x", "")] //testar retorno de erro 'vazio'
        public void RetornarLenth(ulong n, int retornoEsperado)
        {

            var resultado = DecTools.Digits(n);

            Assert.Equal(retornoEsperado, resultado);
        }
    }
}
