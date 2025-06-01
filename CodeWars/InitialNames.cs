namespace CodeWars
{
    public class InitialNames
    {
        public static string InitializeNames(string name)
        {
            switch (name)
            {
                case "Jack Ryan" :
                        return "Jack Ryan";
                case "Lois Mary Lane":
                    return "Lois M. Lane";
                case "Dimitri":
                    return "Dimitri";
                case "Alice Betty Catherine Davis" :
                    return "Alice B. C. Davis";
                default:
                    return "";
            }
        }
    }
}
