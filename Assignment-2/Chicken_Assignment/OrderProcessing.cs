using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chicken_Assignment
{
    class OrderProcessing //Whenever an order needs to be processed, a new thread is instantiated from this class
    {
        private int amount, cardNo, ID, value;
        private double totalCost, shippingHandling = 4.99;
        private string receiptProcessing = "PROCESSING THE ORDER";

        public OrderProcessing(OrderClass tick, int p)
        {
            amount = tick.getAmt();
            cardNo = tick.getCardNo();
            ID = tick.getID();
            value = p;
        }

        public void calculateCharge() // Checks the credit card rng and then calculateCharge the order
        {
            if (checkCardNo())
            {
                double tax = (amount * value) * (0.97);
                totalCost = (amount * value) + tax + shippingHandling;
                //Console.WriteLine("***************************************ORDER PROCESSING******************************************************");
                receiptProcessing = ("\n\tVENDOR ID No. " + ID + ": ORDER PROCESSED. TOTAL PRICE OF " + amount + " CHICKENS AT " + value.ToString("C") + " IS " + totalCost.ToString("C") + ".");
                //Console.WriteLine("*************************************************************************************************************");
            }
            else
                receiptProcessing = ("\n\tVENDOR ID No. " + ID + ": ORDER COULD NOT BE PROCESSED. INVALID CREDENTIALS.");

        }

        public bool checkCardNo()
        {
            if (cardNo >= 5000 && cardNo <= 7000)
                return true;
            else
                return false;
        }

        public string printOrder() //Confirmation order to retailer when the order is complete
        {
            //Console.WriteLine("***************************************ORDER PROCESSING******************************************************");
            return receiptProcessing;
            //Console.WriteLine("*************************************************************************************************************");
        }
    }
}
