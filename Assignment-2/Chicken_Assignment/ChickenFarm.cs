using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace Chicken_Assignment
{
    public delegate void priceCutEvent(int value);

    class ChickenFarm
    {
        static Random rng = new Random();
        Retailer chickenStore;
        static MultiCellBuffer buffer;
        public static event priceCutEvent priceCut; // Defining the event
        private static int chickenPrice = 5;
        private static int p;


        public ChickenFarm()
        { }//No operation

        public ChickenFarm(Retailer rng, MultiCellBuffer k)//Oveloaded Constructor
        {
            chickenStore = rng;
            buffer = k;
            checkShop();
        }

        public int getPrice() 
        { 
            return chickenPrice; 
        }

        public void checkShop()
        {
            chickenStore.checkShop();
        }


        public void PricingModel() //Determining the chicken prices
        {
            Stopwatch watch = new Stopwatch(); // for time elapsed
            DateTime time = new DateTime();
            time = DateTime.Now;
            string format = "HH:mm:ss";

            Console.WriteLine("\n\tCHICKEN SHOP IS NOW OPEN!!!!! START TIME: " + time.ToString(format));
            watch.Start();
            int value;

            while (p <= 10)
            {
                Thread.Sleep(2000); //Changing the value every 2 seconds 
                value = rng.Next(4, 10);//Random model to generate the prices
                Console.WriteLine("\n\tCURRENT MARKET PRICE OF CHICKEN IS ${0:N}\n", chickenPrice);
                changePrice(value);
            }
            watch.Stop();
            chickenStore.checkShop();
            Thread.Sleep(3000);
            Console.WriteLine("\n\tOUT OF STOCK. CHICKEN SHOP IS NOW DONE FOR THE DAY !! CLOSING TIME: " + watch.Elapsed);
            Console.WriteLine("\n\tPRESS ANY KEY TO EXIT");
            Console.ReadKey();
            Environment.Exit(0);
        }

        public static void changePrice(int value)
        {
            if (value < chickenPrice)
            {
                if (priceCut != null)
                {
                    Console.WriteLine("\n\t\\\\\\\\\\\\****DISCOUNT!! DISCOUNT!!****////////");
                    priceCut(value); // emit an event and call the event handlers in the Retailers
                    Console.WriteLine("\n\t\\\\\\\\\\\\*****************************////////\n");
                    p++;
                }
            }
            chickenPrice = value;
        }

        public string ship(int unit) //sends an order to the Order Processing class.
        {
            string shipment;
            shipment = buffer.getOneCell(unit);
            EncoderDecoder encrypt = new EncoderDecoder();
            OrderProcessing progress = new OrderProcessing(encrypt.decoder(shipment), chickenPrice); //Decoder object to convert the string into the order object.

            Thread order = new Thread(new ThreadStart(progress.calculateCharge));
            order.Start();
            
            while (order.IsAlive)
            {
                Thread.Sleep(50);
            }
            Console.WriteLine("***************************************ORDER PROCESSING******************************************************");
            return progress.printOrder();
        }                
    }
}
