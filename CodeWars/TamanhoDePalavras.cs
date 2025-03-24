namespace CodeWars
{
    public class TamanhoDePalavras
    {
        public static string[] AddLength(string str)
        {
            var caracteres = str.Split(' ');
            var resultado = new string[caracteres.Length];     
            for (int i = 0; i < caracteres.Length; i++)
            {
                resultado[i] = $"{caracteres[i]} {caracteres[i].Length}";
            }
            return resultado;
        }
    }
}
