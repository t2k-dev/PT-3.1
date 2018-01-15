using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Xml;

namespace StringTransformations
{
    class Functions
    {
        static char[] CharsToTrim = { '.', ',', '-', '+', ' ','_' };
          
        static public string StrTrans(string title)
        {
            int i;
            string[] Words;
            string Word;
            title = title.ToLower();
            title = Regex.Replace(title, @"_", " ");
            title = title.TrimStart(CharsToTrim);
            title = title.Replace(@"-", " - ");
            title = Regex.Replace(title, @"  +", " ");
            title = Functions.checkAlwaysDeleteList(title);
            //var appSettings = ConfigurationManager.AppSettings.
            //string s = PT.Properties.Settings.Default.siteNames;


            Words = title.Split(' ');
            for (i = 0; i < Words.Length; i++)
            {
                Word = Words[i];
                switch (Word)
                {
                    case "a":
                        continue;
                    case "in":
                        continue;
                    case "but":
                        continue;
                    case "is":
                        continue;
                    case "at":
                        continue;
                    case "on":
                        continue;
                    case "am":
                        continue;
                    case "the":
                        continue;
                    case "of":
                        continue;
                    case "or":
                        continue;
                    case "":
                        continue;
                 
                }
                Word = Word[0].ToString().ToUpper() + Word.Substring(1, Word.Length - 1);
                Words[i] = Word;
            }
            
            title = "";
            for (i = 0; i < Words.Length; i++)
            {
                title = title + " " + Words[i];
            }
            try
            {
                title = title.TrimStart(' ');
                title = title[0].ToString().ToUpper() + title.Substring(1, title.Length - 1);
                title = title.TrimEnd(' ');
                //Exceptions
                title = title.Replace(@"A - Ha", "A-ha");
                title = title.Replace(@"Jay - Z", "Jay-Z");
                title = title.Replace(@"Ne - Yo", "Ne-Yo");
                title = title.Replace(@"E - Type", "E-Type");
                title = title.Replace(@"G - Unit", "G-Unit");
                title = title.Replace(@"Teach - In", "Teach-In");
                title = title.Replace(@"A - Teens", "A-Teens");
                title = title.Replace(@"A - Studio", "A-studio");
                title = title.Replace(@"J - Five", "J-Five");
                title = title.Replace(@"C - Block", "C-Block");
                title = title.Replace(@"Ac - Dc", "AC-DC");
                title = title.Replace(@"Ак - 47", "Ак-47");
                title = title.Replace(@"Би - 2", "Би-2");

                title = title.Replace(@" - a ", " - A ");
                title = title.Replace(@" - the ", " - The ");
                title = title.Replace(@" - in ", " - In ");
                title = title.Replace(@" - is ", " - Is ");
                title = title.Replace(@" - but ", " - But ");
                title = title.Replace(@" - at ", " - At ");
                title = title.Replace(@" - on ", " - On ");
                title = title.Replace(@" - am ", " - Am ");
                title = title.Replace(@" - of ", " - Of ");
                title = title.Replace(@" - or ", " - Or ");                


                if (Regex.IsMatch(title,@"\("))
                {
                    int idx = title.IndexOf('(');
                    title = title.Substring(0, idx + 1) + title[idx+1].ToString().ToUpper() + title.Substring(idx+2,title.Length-idx-2);
                }


            }
            catch (IndexOutOfRangeException) { }
            return title;
            
        }
        
        //------------------------------------------------------------------------------------------------------------------------

        static public string RemoveNumber(string title)
        {
            int j = 0;
            while (j <= title.Length)
            {
                if (Regex.IsMatch(title[0].ToString(), @"\d"))
                {
                    title = title.Substring(1, title.Length - 1);
                }
                else { break; }
                j++;
            }
            return title;
        }

        //------------------------------------------------------------------------------------------------------------------------

        static public string AddArtist(string title, string artist)
        {
            int j = 0;
            int numInd;
            string str = title;
            while (j <= title.Length)
            {
                if (Regex.IsMatch(title[0].ToString(), @"\d"))
                {
                    numInd = j;
                    title = title.Substring(1, title.Length - 1); 
                }
                else { break; }
                j++;
            }
            title = title.TrimStart(CharsToTrim);
            str = str.Substring(0, j);
            if (j > 0) { str = str + ". "; }
            return str + artist + " - " + title; 
        
        }

        //------------------------------------------------------------------------------------------------------------------------

        static public string Translit(string title)
        {
            title = title.ToLower();
            title = title.Replace(@"ia", "ya");
            title = title.Replace(@"iy", "ый");

            Dictionary<string,string> words = new Dictionary<string,string>();
            words.Add("щ", "sch");
            words.Add("ю", "yu");
            words.Add("я", "ya");
            words.Add("ч", "ch");
            words.Add("ш", "sh");
            words.Add("ё", "yo");
            words.Add("ж", "zh");
            words.Add("а", "a");
            words.Add("б", "b");
            words.Add("в", "v");
            words.Add("г", "g");
            words.Add("д", "d");
            words.Add("е", "e");
            words.Add("з", "z");
            words.Add("и", "i");
            words.Add("й", "j");
            words.Add("к", "k");
            words.Add("л", "l");
            words.Add("м", "m");
            words.Add("н", "n");
            words.Add("о", "o");
            words.Add("п", "p");
            words.Add("р", "r");
            words.Add("с", "s");
            words.Add("т", "t");
            words.Add("у", "u");
            words.Add("ф", "f");
            words.Add("х", "h");
            words.Add("ц", "c");
            words.Add("ь", "\'");
            words.Add("ъ", "\'");
            words.Add("ы", "i");
            words.Add("э", "e");
        foreach (KeyValuePair<string, string> pair in words)
        {
            title = title.Replace(pair.Value, pair.Key);
        }
        title = title.Replace(@" би ", " бы ");
        title = title.Replace(@"y", "ы");
        
            return title;
        }

        //------------------------------------------------------------------------------------------------------------------------

        static public string Replacer(string title, string first_string, string second_string)
        {
            return title.Replace(first_string, second_string);         
        }

        //------------------------------------------------------------------------------------------------------------------------

        static public string checkAlwaysDeleteList(string title)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("..\\..\\ptStrings.xml");
            XmlNodeList nodeList = doc.GetElementsByTagName("sName");
            foreach (XmlElement el in nodeList)
            {
                title = title.Replace(el.InnerText, "");
            }
            return title;
        }


    }
}
