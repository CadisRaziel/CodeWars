using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class UseSpan
    {
        public static void IneficienteTradicional()
        {
            //Dados de uma venda (simuland um registro de banco de dados ou arquivo)
            string linhaItem = "42|2024-03-15|299.99|Playstation5";


            //Contador de tempo
            Stopwatch sw = Stopwatch.StartNew();

            //Processamento ineficiente(aloca string a cada operação)
            for (int i = 0; i < 100000; i++)
            {
                string[] fields = linhaItem.Split('|');    // Aloca 4 strings !
                int id = int.Parse(fields[0]);             // Conversão lenta
                DateTime data = DateTime.Parse(fields[1]); // Mais alocação
                double preco = double.Parse(fields[2]);    // Outra alocaçao
                string produto = fields[3];                // Ja alocado pelo split
            }

            sw.Stop();

            Console.WriteLine($"Tempo gasto: {sw.ElapsedMilliseconds}ms");

        }


        public static void EficienteComSpan()
        {
            //Dados de uma venda (simuland um registro de banco de dados ou arquivo)
            string linhaItem = "42|2024-03-15|299.99|Playstation5";


            //Contador de tempo
            Stopwatch sw = Stopwatch.StartNew();

            //Processamento ineficiente(aloca string a cada operação)
            for (int i = 0; i < 100000; i++)
            {
                ReadOnlySpan<char> registroSpan = linhaItem.AsSpan(); //Convertendo a string linhaItem em um readOnlySpan de char
                //Isso cria uma janela para a string existente, acessando diretamente a memoria onde ela ta armazeanda sem COPIA-LA !!! 
                //registroSpan -> vai ser alocada na stack, funciona como ponteiro seguro para acessar partes da string original

                int posicaoPipe = registroSpan.IndexOf('|'); //Encontro o indice do primeiro caracter

                int id = int.Parse(registroSpan.Slice(0, posicaoPipe)); //Estou fatiando do inicio ate o posicao pipe que é o primeir | ou seja o ID
                //Vai converter o readOnlySpan para um int !

                ReadOnlySpan<char> parteRestante = registroSpan.Slice(posicaoPipe + 1);//Agora estou fatiando a partir do segundo | ate o final dele o 3 | ou seja o 2º iten da string
                posicaoPipe = parteRestante.IndexOf('|'); //Encontro o indice do primeiro caracter da segunda parte 

                DateTime data = DateTime.Parse(parteRestante.Slice(0, posicaoPipe)); //Mapeio o que tem dentro desse segundo iten | | e converto para dateTime

                parteRestante = parteRestante.Slice(0, posicaoPipe + 1); //vou para o item que esta no 3 |
                posicaoPipe = parteRestante.IndexOf('|');//Encontro o indice do primeiro caracter da terceira parte

                double preco = double.Parse(parteRestante.Slice(0, posicaoPipe));//Mapeio a terceira parte ate o final do | e converto para double

                string produto = parteRestante.Slice(posicaoPipe + 1).ToString();//Agora apos o ultimo | eu converto para string (estou fazendo uma locaçao de string porém é no final !)


                //Com span e slice eu to olhando para as strings originais e nao estou criando novas, só o produto que é um caso a parte..
            }

            sw.Stop();

            Console.WriteLine($"Tempo gasto: {sw.ElapsedMilliseconds}ms");
        }
    }
}
