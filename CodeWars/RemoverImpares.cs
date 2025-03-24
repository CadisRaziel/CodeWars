namespace CodeWars
{
    public class RemoverImpares
    {
        public static List<int> FilterOddNumber(List<int> listOfNumbers)
        {
            listOfNumbers.RemoveAll(x => x % 2 == 0); 
            return listOfNumbers; 
        }
    }
}
