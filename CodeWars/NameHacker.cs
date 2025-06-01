    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

namespace CodeWars
{
    public class NameHacker
    {
        public static string AliasGen(string fName, string lName)
        {

            if (!char.IsLetter(fName[0]) || !char.IsLetter(lName[0]))
                return "Your name must start with a letter from A - Z.";

            string firstKey = fName[0].ToString().ToUpper();
            string lastKey = lName[0].ToString().ToUpper();

          


            var FirstName = new Dictionary<string, string>()
            {
                {"M", "Malware"},
                {"F", "Function"},
                {"D", "Data"},
                {"B", "Beta"},
                {"H", "Half-life"},
                {"A", "Alpha"},
                {"C", "Cache"}
            };

            var Surname = new Dictionary<string, string>()
            {
                {"M", "Mike"},
                {"T", "T-Rex"},
                {"P", "Payload"},
                {"W", "Worm"},
                {"K", "Killer"},
                {"A", "Analogue"},
                {"B", "Bomb"},
                {"C", "Catalyst"}
            };

            if (!FirstName.ContainsKey(firstKey) || !Surname.ContainsKey(lastKey))
                return "Your name must start with a letter from A - Z.";

            var firstMap = FirstName.Select(x => x).Where(x => x.Key.First() == fName.First());
            var lastMap = Surname.Select(x => x).Where(x => x.Key.First() == lName.First());         

            var FirstNameResult = firstMap.Select(x => x.Value);
            var LastNameResult = lastMap.Select(x => x.Value);

            return $"{string.Join("", FirstNameResult)} {string.Join("", LastNameResult)}";
        }
    }
}
