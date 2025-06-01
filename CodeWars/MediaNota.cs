
namespace CodeWars
{
    public class MediaNota
    {
        public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
        {
           double media = ClassPoints.Average();

            if(media > YourPoints)
            {
                return false;
            }
           return true;
        }
    }
}
