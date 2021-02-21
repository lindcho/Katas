using System.Collections.Generic;
using System.Linq;

namespace _7kyu_AlternateCapitalization
{
    public class TextCapitaliser
    {
        public static string[] Capitalize(string s)
        {
            var output = "";
            var result = new List<string>();
            var charArray = s.ToCharArray();
            var counter = 1;
            while (counter <= 2)
            {
                for (var i = 0; i < s.Length; i++)
                {
                    if (counter == 1)
                    {
                        if (i % 2 == 0)
                        {
                            output += charArray[i].ToString().ToUpper();
                        }
                        else
                        {
                            output += charArray[i].ToString().ToLower();
                        }
                    }
                    else
                    {
                        if (i % 2 != 0)
                        {
                            output += charArray[i].ToString().ToUpper();
                        }
                        else
                        {
                            output += charArray[i].ToString().ToLower();
                        }
                    }

                }
                result.Add(output);
                counter++;
                output = string.Empty;
            }

            return result.ToArray();
        }
    }



}