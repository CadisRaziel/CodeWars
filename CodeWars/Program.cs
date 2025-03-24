using CodeWars;

public class MainClass
{
    public static void Main()
    {
        //string result = RemoveNumber.StringClean("oi23");
        //Console.WriteLine(result);


        //string[] result = TamanhoDePalavras.AddLength("ola amigo oi");
        //Console.WriteLine(string.Join(", ", result));

        List<int> list = new List<int>() { 1, 2, 2, 2, 4, 3, 4, 5, 6, 7 };   
        var result = RemoverImpares.FilterOddNumber(list);
        Console.WriteLine(string.Join(", ", result));

    }
}
