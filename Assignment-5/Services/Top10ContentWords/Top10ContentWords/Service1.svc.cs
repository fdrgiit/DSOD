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

    public string[] Top10Words(string url)
    {
        Web2StringService.ServiceClient proxy = new Web2StringService.ServiceClient();//Service from the pdf
        string word = proxy.GetWebContent(url);

        string orgiWord = @word;
        string oldWord = @"[^a-zA-Z]";
        string convert = Regex.Replace(orgiWord, oldWord, " ").ToLower();

        ArrayList words = new ArrayList();
        Hashtable table = new Hashtable();
        int flag = 0;
        int counter = 0;

        foreach (string count in convert.Split())
        {
            if (count.Trim().Length != 0)
            {
                words.Add(count);

                if (table.Contains(count) == false)
                {
                    table.Add(count, 1);
                    counter++;
                }
                else
                {
                    flag = Convert.ToInt32(table[count]);
                    flag++;
                    table[count] = flag;
                }
            }
        }

        ArrayList list = new ArrayList();

        foreach (DictionaryEntry entry in table)
        {
            hashPair two = new hashPair(entry.Key.ToString(), Convert.ToInt32(entry.Value));
            list.Add(two);
        }

        quickSort(list, 0, list.Count - 1);

        string[] sort = new string[10];

        for (int i = list.Count - 1, j = 0; i >= 0 && j < 10; i--, j++)
        {
            sort[j] = String.Copy(((hashPair)list[list.Count - 1 - j]).getKey());
        }
        return sort;
    }

    private static int partition(ArrayList list, int start, int end)
    {
        int i = start - 1;
        int j = start;
        hashPair flag;
        for (; j < end; j++)
        {
            if ((((hashPair)list[j]).getValue() < ((hashPair)list[end]).getValue()))
            {
                i++;
                flag = new hashPair(((hashPair)list[j]).getKey(), ((hashPair)list[j]).getValue());
                ((hashPair)list[j]).setKey(((hashPair)list[i]).getKey());
                ((hashPair)list[j]).setValue(((hashPair)list[i]).getValue());
                ((hashPair)list[i]).setKey(flag.getKey());
                ((hashPair)list[i]).setValue(flag.getValue());
            }
        }
        i++;
        flag = new hashPair(((hashPair)list[end]).getKey(), ((hashPair)list[end]).getValue());
        ((hashPair)list[end]).setKey(((hashPair)list[i]).getKey());
        ((hashPair)list[end]).setValue(((hashPair)list[i]).getValue());
        ((hashPair)list[i]).setKey(flag.getKey());
        ((hashPair)list[i]).setValue(flag.getValue());
        return i;
    }

    private static void quickSort(ArrayList list, int start, int end)
    {
        if (start < end)
        {
            int mid = partition(list, start, end);
            quickSort(list, start, mid - 1);
            quickSort(list, mid + 1, end);
        }
        return;
    }

    private class hashPair
    {
        private string hash;
        private int flag;
        public hashPair(string hash, int flag)
        {
            this.hash = String.Copy(hash);
            this.flag = flag;
        }

        public int getValue()
        {
            return flag;
        }

        public string getKey()
        {
            return hash;
        }

        public void setValue(int flag)
        {
            this.flag = flag;
        }

        public void setKey(string hash)
        {
            this.hash = String.Copy(hash);
        }
    }

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
    public string Sort(string c)
    {
        string temporary;
        // if (c.Contains(@"[^a-zA-Z\s]"))
        // {
        //     return "Invalid Input Please Provide a Valid Input!";
        //  }
        // else
        //{
        temporary = c.Replace(" ", "");
        char[] cList = temporary.ToCharArray();
        string output = "";
        if (cList.Length != 0)
        {
            mergeSort(cList, 0, cList.Length - 1);
            foreach (char i in cList)
            {
                output += i.ToString();
            }
        }
        return output;
        // }
    }

    private static void merge(char[] characterList, int initial, int final, int middle)
    {
        int rightlength = final - middle + 1;
        int leftlength = middle - initial + 2;

        char[] l = new char[leftlength];
        char[] r = new char[rightlength];

        l[leftlength - 1] = (char)123;
        r[rightlength - 1] = (char)123;

        for (int i = 0; i < leftlength - 1; i++)
        {
            l[i] = characterList[initial + i];
        }

        for (int i = 0; i < rightlength - 1; i++)
        {
            r[i] = characterList[middle + 1 + i];
        }

        int j = 0, k = 0;
        for (int i = initial; i < final + 1; i++)
        {
            if (l[j] < r[k])
            {
                characterList[i] = l[j];
                j++;
            }
            else
            {
                characterList[i] = r[k];
                k++;
            }
        }
        return;
    }

    private static void mergeSort(char[] characters, int initial, int final)
    {
        int middle = (final + initial) / 2;

        if (initial < final)
        {
            mergeSort(characters, initial, middle);
            mergeSort(characters, middle + 1, final);
            merge(characters, initial, final, middle);
        }
        return;
    }
    public int palindrome(string s)
    {
        char[] startingChar = s.ToCharArray();

        int t1 = 0;
        int t2 = 0;

        int maximumLength1 = 0;
        int maximumLength2 = 0;

        for (int i = 0; i < s.Length; i++)
        {
            t1 = middle(startingChar, i);
            if (t1 > maximumLength1)
            {
                maximumLength1 = t1;
            }
            t2 = mirror(startingChar, i);
            if (t2 > maximumLength2)
            {
                maximumLength2 = t2;
            }
        }
        if (maximumLength1 > maximumLength2)
        {
            return maximumLength1;
        }
        else
        {
            return maximumLength2;
        }
    }

    private static int middle(char[] initial, int p)
    {
        int length = initial.Length;
        int maximumLength = 1;
        int left = p - 1;
        int right = p + 1;
        while (left >= 0 && right < length)
        {
            if (initial[left] == initial[right])
            {
                left--;
                right++;
                maximumLength += 2;
            }
            else
                break;
        }
        return maximumLength;
    }

    private static int mirror(char[] initial, int p)
    {
        int length = initial.Length;

        int maximumLength1 = 0;
        int maximumLength2 = 0;

        int l1 = p;
        int r1 = p + 1;

        while (l1 >= 0 && r1 < length)
        {
            if (initial[l1] == initial[r1])
            {
                l1--;
                r1++;
                maximumLength1 += 2;
            }
            else
                break;
        }
        int l2 = p - 1;
        int r2 = p;
        while (l2 >= 0 && r2 < length)
        {
            if (initial[l2] == initial[r2])
            {
                l2--;
                r2++;
                maximumLength2 += 2;
            }
            else
                break;
        }

        if (maximumLength1 < maximumLength2)
        {
            return maximumLength2;
        }
        else if (maximumLength1 > maximumLength2)
        {
            return maximumLength1;
        }
        else
        {
            return maximumLength1;
        }
    }

    private string[] Words = { "a", "about", "above", "after", "again", "against", "all", "am", "an", "and", "any", "are", "aren't", "as", "at", "be", "because", "been", "before", "being", "below", "between", "both", "but", "by", "can't", "cannot", "could", "couldn't", "did", "didn't", "do", "does", "doesn't", "doing", "don't", "down", "during", "each", "few", "for", "from", "further", "had", "hadn't", "has", "hasn't", "have", "haven't", "having", "he", "he'd", "he'll", "he's", "her", "here", "here's", "hers", "herself", "him", "himself", "his", "how", "how's", "i", "i'd", "i'll", "i'm", "i've", "if", "in", "into", "is", "isn't", "it", "it's", "its", "itself", "let's", "me", "more", "most", "mustn't", "my", "myself", "no", "nor", "not", "of", "off", "on", "once", "only", "or", "other", "ought", "our", "ours ", "ourselves", "out", "over", "own", "same", "shan't", "she", "she'd", "she'll", "she's", "should", "shouldn't", "so", "some", "such", "than", "that", "that's", "the", "their", "theirs", "them", "themselves", "then", "there", "there's", "these", "they", "they'd", "they'll", "they're", "they've", "this", "those", "through", "to", "too", "under", "until", "up", "very", "was", "wasn't", "we", "we'd", "we'll", "we're", "we've", "were", "weren't", "what", "what's", "when", "when's", "where", "where's", "which", "while", "who", "who's", "whom", "why", "why's", "with", "won't", "would", "wouldn't", "you", "you'd", "you'll", "you're", "you've", "your", "yours", "yourself", "yourselves" };
    public string Stemming(string input)
    {
        string output = "";
        string[] split = input.Split(' ');
        string current;
        string changed;

        for (int i = 0; i < split.Length; i++)
        {
            current = split[i];
            changed = split[i].ToLower();
            int lastIndex = 0;

            if (changed.EndsWith("y") || changed.EndsWith("s"))
            {
                if (changed.EndsWith("ty") || changed.EndsWith("fy") || changed.EndsWith("ly") || changed.EndsWith("es"))
                {
                    if (changed.EndsWith("ity") || changed.EndsWith("ify"))
                    {
                        lastIndex = 3;
                    }
                    else
                    {
                        lastIndex = 2;
                    }
                }
                else if (changed.EndsWith("acy") || changed.EndsWith("ous"))
                {
                    if (changed.EndsWith("ious") || changed.EndsWith("eous"))
                    {
                        lastIndex = 4;
                    }
                    else
                    {
                        lastIndex = 3;
                    }
                }
                else
                {
                    lastIndex = 1;
                }
                changed = changed.Substring(0, changed.Length - lastIndex);
            }
            else if (changed.EndsWith("al") || changed.EndsWith("er") || changed.EndsWith("or")
                     || changed.EndsWith("en") || changed.EndsWith("ic") || changed.EndsWith("ed"))
            {
                if (changed.EndsWith("ial"))
                {
                    lastIndex = 3;
                }
                else
                {
                    lastIndex = 2;
                }
                changed = changed.Substring(0, changed.Length - lastIndex);
            }
            else if (changed.EndsWith("dom") || changed.EndsWith("ism") || changed.EndsWith("ist")
                     || changed.EndsWith("ate") || changed.EndsWith("ize")
                     || changed.EndsWith("ise") || changed.EndsWith("ful") || changed.EndsWith("ish")
                     || changed.EndsWith("ive") || changed.EndsWith("ing"))
            {
                if (changed.EndsWith("itive") || changed.EndsWith("ative"))
                {
                    lastIndex = 5;
                }
                else
                {
                    lastIndex = 3;
                }
                changed = changed.Substring(0, changed.Length - lastIndex);
            }
            else if (changed.EndsWith("ance") || changed.EndsWith("ence") || changed.EndsWith("ment")
                     || changed.EndsWith("ship") || changed.EndsWith("sion") || changed.EndsWith("tion") || changed.EndsWith("able")
                     || changed.EndsWith("ible") || changed.EndsWith("ness") || changed.EndsWith("less"))
            {
                if (changed.EndsWith("ation") || changed.EndsWith("ition"))
                {
                    lastIndex = 5;
                }
                else
                {
                    lastIndex = 4;
                }
                changed = changed.Substring(0, changed.Length - lastIndex);
            }
            else if (changed.EndsWith("esque"))
            {
                lastIndex = 5;
                changed = changed.Substring(0, changed.Length - lastIndex);
            }


            if (lastIndex == 0)
            {
                output += " " + current;
            }
            else
            {
                output += " " + current.Substring(0, current.Length - lastIndex);
            }
        }


        return output.Trim();
    }

    public string deleteChar(string s1, string s2)
    {
        char[] character1 = s1.ToCharArray();
        char[] character2 = s2.ToCharArray();

        Boolean[] h = new Boolean[256];
        foreach (char c in character2)
            h[c - 1] = true;
        int f = 0, s = 0;

        Boolean flag = false;

        while (f < s1.Length - 1)
        {
            f++;
            if (h[character1[s] - 1])
            {
                flag = true;
                character1[s] = character1[f];
                if (!h[character1[s] - 1])
                    s++;
            }
            else
            {
                if (flag)
                    character1[s] = character1[f];
                if (!h[character1[s] - 1])
                    s++;
            }
        }
        character1[s] = '\0';
        string result = new string(character1, 0, s);
        return result;
    }

    public string[] Permutation(string input)
    {
        string str = Regex.Replace(input, @"[^a-zA-Z0-9]", "");
        char[] chars = str.Trim().ToCharArray();
        Hashtable hash = new Hashtable();
        int count = 0;
        ArrayList charList = new ArrayList();
        foreach (char c in chars)
        {
            if (hash.Contains(c) == false)
            {
                hash.Add(c, 1);
                //charList.Add(c);
            }
        }

        char[] charArray = new char[hash.Count];
        Boolean[] flag = new Boolean[hash.Count];

        foreach (DictionaryEntry entry in hash)
        {
            charArray[count] = (char)entry.Key;
            count++;
        }

        ArrayList allPermutation = new ArrayList();
        dfs(0, "", flag, charArray, allPermutation);

        //for (int i = 0; i < allPermutation.Count; i++)
        //    Console.WriteLine(allPermutation[i].ToString());

        return (string[])allPermutation.ToArray(typeof(string));
    }

    private static void dfs(int step, string s, Boolean[] flag, char[] charArray, ArrayList allPermutation)
    {
        if (step == flag.Length)
        {
            allPermutation.Add(s);
            return;
        }
        for (int i = 0; i < flag.Length; i++)
        {
            if (flag[i] == false)
            {
                flag[i] = true;
                string temp = String.Copy(s);
                s += (charArray[i].ToString());
                //Console.WriteLine(s);
                dfs(step + 1, s, flag, charArray, allPermutation);
                s = String.Copy(temp);
                flag[i] = false;
            }
        }
    }

    }
}
