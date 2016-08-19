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

namespace Top10Words
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : IService1
    {
        private string address;
        private string markup;
        private string[] content;
        private List<Words> stop = new List<Words>();
        private string type;
        private string filter;

        public Service1()
        {
            this.markup = "";
            content = new string[10];
            this.type = "";
            this.filter = "";
        }

        public string[] Top10ContentWords(string url)
        {
            this.address = url;
            Web2StringService.ServiceClient w2s = new Web2StringService.ServiceClient();
            string word = w2s.GetWebContent(url);
            this.markup = FilterAndRemoveStopWords(word);
            this.parse();
            return content;
        }

        public string FilterAndRemoveStopWords(string text)
        {
            this.type = text;
            this.runFilter(true);
            return this.filter;
        }

    private void runFilter(bool removeStopWords)
    {
        this.filter = this.type;
       
        string pattern = "";
        string replacement = " ";
       
        this.filter = Regex.Replace(this.filter, "<script.*?</script>", replacement, RegexOptions.Singleline | RegexOptions.IgnoreCase);

        this.filter = Regex.Replace(this.filter, "<style.*?</style>", replacement, RegexOptions.Singleline | RegexOptions.IgnoreCase);
      
        pattern = @"</?\w+((\s+\w+(\s*=\s*(?:"".*?""|'.*?'|[^'"">\s]+))?)+\s*|\s*)/?>";
        this.filter = Regex.Replace(this.filter, pattern, replacement, RegexOptions.Singleline | RegexOptions.IgnoreCase);

        pattern = @"<.*?>";
        this.filter = Regex.Replace(this.filter, pattern, replacement, RegexOptions.Singleline | RegexOptions.IgnoreCase);

        pattern = @"&nbsp;";
        this.filter = Regex.Replace(this.filter, pattern, replacement);

        pattern = @"&amp;";
        this.filter = Regex.Replace(this.filter, pattern, " and ");

        pattern = @"&#8217;";
        this.filter = Regex.Replace(this.filter, pattern, "'");

        pattern = @", ";
        this.filter = Regex.Replace(this.filter, pattern, replacement);

        pattern = @"\. |\?|\!";
        this.filter = Regex.Replace(this.filter, pattern, replacement);

        pattern = @"&.*?;";
        this.filter = Regex.Replace(this.filter, pattern, replacement);

        pattern = @"\s+";
        this.filter = Regex.Replace(this.filter, pattern, replacement);

        if (removeStopWords)
        {
            this.removeStopWords();
        }
    }
    private void removeStopWords()
    {
        var serverPath = System.Web.Hosting.HostingEnvironment.MapPath("~/App_Data/stopWords.txt");
        string text = System.IO.File.ReadAllText(serverPath);

        string[] stopWords = text.Split(',');
        string replacement = " ";

        foreach (string stopWord in stopWords)
        {
            string pattern = " " + stopWord + " ";
            this.filter = Regex.Replace(this.filter, pattern, replacement, RegexOptions.IgnoreCase);
        }
    }

    private void parse()
    {
        string[] words = markup.Split(' ');
           
        foreach (string word in words)
        {
            Words wc = new Words(word);
            if (word != "")
            {
                if (!stop.Contains(wc))
                {
                    stop.Add(wc);
                }
            }
        }

        foreach (Words word in stop)
        {
            string targetWord = " " + word.getName() + " ";
            int result = countWord(targetWord);
            word.setOccurrences(result);
        }

        this.stop.Sort();

        for (int i = 0; i < 10; i++)
        {
            this.content[i] = stop[i].getName();
        }
    }

    private int countWord(string word)
    {
        int occurrences = 0;
 
        int i = 0;
        while ((i = markup.IndexOf(word, i)) != -1)
        {
            i += word.Length;
            occurrences++;
        }
        return occurrences;
    }


    }
}
