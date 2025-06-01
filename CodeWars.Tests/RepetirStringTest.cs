using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Test
{
    public class RepetirStringTest
    {
        [Fact(DisplayName = "Deve repetir o texto o número de vezes especificado e deve ter sucesso. FACT")]
        public void RepeatStr_DeveRepetirStringCorretamenteFact()
        {
            // Arrange
            int vezes = 3;
            string textoAseRepetir = "*";

            // Act
            var resultado = RepetirString.RepeatStr(vezes, textoAseRepetir);

            // Assert
            Assert.Equal("***", resultado);
        }

        [Theory(DisplayName = "Deve repetir o texto o número de vezes especificado e deve ter sucesso.")]
        [InlineData(3, "*", "***")] //Testar sucesso
        [InlineData(2, "abc", "abcabc")] //Testar erro
        [InlineData(0, "x", "")] //testar retorno de erro 'vazio'
        public void RepeatStr_DeveRepetirStringCorretamenteTheory(int vezes, string texto, string esperado)
        {
            //Repare que essa função e a de cima testam o mesmo metodo
            //Porém a de cima eu ignoro o fato que meu metodo tem retorno e parametro e monto tudo auqi no teste como se voce um metodo que retorna vazio
            //Isso funciona, porém não é o correto pois tecnicamente meu metodo tem retorno e parametros...

            //Agora iremos fazer da forma correta, utilizando o 'Theory'
            //Meu metodo tem retorno 'static string' e paramtros 'vezes' e 'texto'
            //o 'esperado' é o retorno da função, eu preciso passa-lo como parametro


            // Act
            var resultado = RepetirString.RepeatStr(vezes, texto);

            // Assert
            Assert.Equal(esperado, resultado);
        }

        [Fact(DisplayName = "Deve repetir o texto o número de vezes especificado e deve ter falha.")]
        public void RepeatStr_DeveFalharSeResultadoIncorreto()
        {

            //Essa função esta errada, pois se der errado eu não trato na função...
            //Eu trato direto aqui no teste e isso não pode
            //Porém como eu iria retornar um erro em uma função simpels ? simples 'try catch'

            // Arrange
            int vezes = 3;
            string textoAseRepetir = "*";

            // Act
            var resultado = RepetirString.RepeatStr(vezes, textoAseRepetir);

            try
            {
                // Assert (esse Assert vai falhar de propósito)
                Assert.Equal("****", resultado);

                // Se chegou aqui, o teste falhou — porque não deu erro como esperado
                Assert.True(false, "O teste deveria falhar, mas passou.");
            }
            catch (Xunit.Sdk.EqualException)
            {
                // Sucesso! O teste falhou como esperávamos
                Assert.True(true);
            }
        }

        //[Fact(DisplayName = "Deve verificar se a string de entrada é nula")]
        //public void Verifica_String_Nil()
        //{
        //    //Esse teste foi interessante sabe porque ?
        //    //Porque no metodo eu não verifico se a string do parametro esta vazia..
        //    //Ou seja o teste vai da erro pois eu to testando a possibilidade da função verificar se a string ta vazia
        //    //No teste acima eu estou fazendo errado.... porque la eu to verificando o erro no teste e não na função !!!


        //    //Arrange
        //    int vezes = 3;
        //    string textoAseRepetir = "";

        //    // Act & Assert
        //    Assert.Throws<ArgumentException>(() => RepetirString.RepeatStr(vezes, textoAseRepetir));
        //}

    }
}
