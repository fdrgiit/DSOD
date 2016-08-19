using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace Chicken_Assignment
{
    class Retailer
    {   
        bool shopCheck = false;
        static int retailCount, flag = 0;
        Random rng = new Random();
        MultiCellBuffer buffer;
        Semaphore pool, pool1;

        public Retailer(MultiCellBuffer i, int j)
        {
            buffer = i;
            retailCount = j;
            pool = new Semaphore(0, j);
            pool1 = new Semaphore(0, j);
        }

        public void retailerFunc()  //instantiation retailer threads  
        {
            
            OrderClass order = new OrderClass(); //Each retailer receives has their own order
            EncoderDecoder encrypt = new EncoderDecoder(); //Object sent to Encoder for encoding
            
            int cost;
            string receipt, callback;
            DateTime time = new DateTime();
            string format = "HH:mm:ss";
            Stopwatch watch = new Stopwatch();

            while (shopCheck == true)
            {
                pool.WaitOne(); 
                flag = flag + 1;
                
                if (flag == retailCount)
                {
                    flag = 0;
                    pool1.Release(retailCount);
                }
                                   
                pool1.WaitOne();
                time = DateTime.Now;
                watch.Start();
                order.setID(Convert.ToInt32(Thread.CurrentThread.Name)); //Execute new order
                order.setAmt(rng.Next(10,50));
                cost = order.getAmt();
                order.setCardNo(rng.Next(5000,7000));

                receipt = encrypt.encoder(order);
                Console.WriteLine("\n\tVENDOR {0} HAS PLACED AN ORDER OF {1} NUMBER OF CHICKENS AT TIME {2}\n", Thread.CurrentThread.Name, cost, time.ToString(format));
                callback = buffer.setOneCell(receipt); // Callback is for the MulticellBuffer to call for checking empty spaces
                watch.Stop();
                Console.WriteLine(callback + "\t" + watch.Elapsed);  
            }
        }
        
        public void chickenOnSale(int p)
        {
            try
                {
                    Console.WriteLine("\n\tCHICKENS ARE FOR DISCOUNTED PRICE AT ${0:N}.", p);
                    pool.Release();
                }
            catch (Exception e)
                {
                    Console.WriteLine("An error occurred: '{0}'", e.ToString());
                }
        }

        public void checkShop()
        {
            if (shopCheck == true)
                shopCheck = false;
            else
                shopCheck = true;
        }

    }
}
