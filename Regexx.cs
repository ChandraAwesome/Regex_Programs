using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Regexx
    {
        public static string matches = "^[a-b]{4}$";

        public static string Website = "^(www\\.)([a-z]+)(\\.com)$";

        public static string Image = "^([a-z0-9]+)(\\.png)$";

        public static string underscore = "^([a-z]+)(_[a-z]+)+$";

        //public static string HtmlTags = "^<[^>]+>$";


        public  bool  Checkmatch(string matching)
        {
            return Regex.IsMatch(matching, matches);
        }

        public bool Checkwebsite(string website) 
        {
            return Regex.IsMatch(website, Website);
        }

        public bool Checkimage(string image) 
        {
            return Regex.IsMatch(image, Image);
        }

        public bool Checkunderscore(string score)
        {
            return Regex.IsMatch(score, underscore);
        }

        public void CheckHtmlTags(string input) 
        {
            //string input = "<p>The <code>Regex</code> is a compiled representation of a regular expression.</p>";

            MatchCollection output = Regex.Matches(input, @"<[^>]+>");

            Console.WriteLine("Html tags are : ");

            foreach(Match match in output) 
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
