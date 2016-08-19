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
    }
}
