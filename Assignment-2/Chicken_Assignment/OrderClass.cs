using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chicken_Assignment
{
    class OrderClass // This contains at least the following private data members and public methods
    {
        private int senderID, cardNo, amount;

        public void setID(int id)
        {
            senderID = id;
        }

        public int getID()
        {
            return senderID;
        }

        public void setCardNo(int n)
        {
            cardNo = n;
        }

        public int getCardNo()
        {
            return cardNo;
        }

        public void setAmt(int c)
        {
            amount = c;
        }

        public int getAmt()
        {
            return amount;
        }

        public string toString() //thread will calculate the totalCost amount of charge
        {
            return ("\n\tVENDOR'S ID: " + senderID + " CREDIT CARD NUMBER: " + cardNo + " PRICE: " + amount);
        }
    }
}
