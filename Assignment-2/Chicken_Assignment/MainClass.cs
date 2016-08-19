using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Chicken_Assignment
{
    class MainClass
    {
        const int nRetailers = 5; //Number of retailers
        const int nBufferSpace = 3;

        static void Main(string[] args)
        {
            MultiCellBuffer buffer = new MultiCellBuffer(nBufferSpace);
            Retailer chickenStore = new Retailer(buffer, nRetailers);
            ChickenFarm chicken = new ChickenFarm(chickenStore, buffer);
           
            ChickenFarm.priceCut += new priceCutEvent(chickenStore.chickenOnSale);

            Thread farmer = new Thread(new ThreadStart(chicken.PricingModel));

            farmer.Start(); //Start one farmer thread 
      
            Thread[] retailers = new Thread[nRetailers];
            for (int i = 0; i < nRetailers; i++) //nRetailers = 5
            {   // Start N retailer threads
                retailers[i] = new Thread(new ThreadStart(chickenStore.retailerFunc));
                retailers[i].Name = (i + 1).ToString();
                retailers[i].Start();
            }

        }
    }
}
