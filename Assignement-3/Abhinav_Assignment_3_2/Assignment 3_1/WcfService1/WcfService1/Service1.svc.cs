using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;


namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : IService1
    {
        public string WordFilter(string word)
        {
            string origString = @word;
            string removeTag = @"(</?)[^>]+?(/?>)|[^a-zA-Z]";
            string stopWords = @"\bare\b|\bam\b|\ba\b|\bthe\b|\ban\b|\bon\b|\bin\b|\bat\b|\bunder\b|\babove\b|\bto\b|\band\b|\bbut\b|\bas\b|\bbecause\b|\bwith\b|\bfor\b|\bso\b|\bthus\b|\btherefore\b|\bhence\b|\bif\b|\belse\b|\bbe\b|\bis\b|\bwhen\b|\bwhere\b|\bwho\b|\bwhat\b|\bwhich\b|\bhow\b|\bof\b|\bbefore\b|\bafter\b|\bthan\b|\bbehind\b|\bbeside\b|\balong\b|\bthrough\b|\bby\b|\bbeen\b|\bwas\b|\bwere\b|\bwhose\b|\binto\b|\bonto\b|\bor\b|\bmoreover\b|\byet\b|\bnevertheless\b|\beither\b|\btoo\b|\bnor\b|\bneither\b|\bonly\b|\bjust\b|\balso\b|\bmerely\b|\bsince\b|\bfrom\b|\babout\b|\bout\b";

            string tagWord = Regex.Replace(origString, removeTag, " ").ToLower();
            string stopWord = Regex.Replace(tagWord, stopWords, " ");

            ArrayList words = new ArrayList();
            foreach (string flag in stopWord.Split())
            {
                if (flag.Trim().Length != 0)
                {
                    words.Add(flag);
                }
            }

            string sentenance = string.Join(" ", (string[])words.ToArray(typeof(string)));
            return sentenance;
        }
    }
}
