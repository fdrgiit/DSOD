using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chicken_Assignment
{
    class EncoderDecoder
    {
        public string encoder(OrderClass dispatch) // The Encoder method will convert an OrderObject into a string.
        {
            int id = dispatch.getID();
            int card = dispatch.getCardNo();
            int cost = dispatch.getAmt();
            return id + "&" + card + "&" + cost + "&";
        }

        public OrderClass decoder(string order) // The Decoder will convert the string back into the OrderObject.
        {
            string[] Split = order.Split(new Char[] {'&'});
            OrderClass detail = new OrderClass();
            detail.setID(Convert.ToInt32(Split[0]));
            detail.setCardNo(Convert.ToInt32(Split[1]));
            detail.setAmt(Convert.ToInt32(Split[2]));
            return detail;
        }
    }
}
