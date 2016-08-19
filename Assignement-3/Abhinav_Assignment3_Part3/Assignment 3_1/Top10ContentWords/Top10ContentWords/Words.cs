using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Top10Words
{
    public class Words : IComparable
    {
        private int counter;
        private string text;

        public Words(string name)
        {
            this.text = name;
            this.counter = 0;
        }

        public void addOccurrence()
        {
            this.counter++;
        }

        public void setOccurrences(int occurrences)
        {
            this.counter = occurrences;
        }

        public string getName()
        {
            return this.text;
        }

        public int getOccurrences()
        {
            return this.counter;
        }

        public override bool Equals(System.Object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Words wc = obj as Words;
            if ((System.Object)wc == null)
            {
                return false;
            }

            return (wc.getName() == this.text);
        }

        public int CompareTo(object obj)
        {
            int returnResult = 0;
            if (obj == null)
                returnResult = -1;

            Words otherWord = obj as Words;

            if (otherWord != null)
            {
                if (this.counter > otherWord.counter)
                    returnResult = -1;
                else if (this.counter < otherWord.counter)
                    returnResult = 1;
                else
                    returnResult = 0;
            }

            return returnResult;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}