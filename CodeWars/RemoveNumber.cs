namespace CodeWars
{
    public class RemoveNumber
    {
        public static string StringClean(string s)
        {

            var numberOfchar = s.ToCharArray();
            string result = "";
            for (int i = 0; i <numberOfchar.Length; i++)
            {
                result += char.IsDigit(numberOfchar[i]) ? "" : numberOfchar[i].ToString();
            }   

            return result;
        }
    }
}
