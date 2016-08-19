using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Chicken_Assignment
{
    class MultiCellBuffer
    {
        private int matrix = 0;
        private string[] matCells;
        private Semaphore locker; // semaphore to manage the matCells
 

        public MultiCellBuffer(int n)
        {
            matrix = n;
            matCells = new string[n];

            for(int i = 0; i < n; i++)
            {
                matCells[i] = "";
            }

            locker = new Semaphore(n, n);//Setting the max value
        }

        public string setOneCell(string top) // write data from one of the available matCells.
        {
            locker.WaitOne(); 
            int unit = -1;
            string result;

            lock (matCells) // lock each unit to ensure the synchronization
            {
                for (int i = 0; i < matrix; i++)
                {
                    if (matCells[i] == "")
                        unit = i;
                }

                if (unit != -1)
                {
                    matCells[unit] = top;
                }
                else
                {
                    Console.WriteLine("\n\tNOT ENOUGH BUFFER SPACE");
                }
            }

            ChickenFarm store = new ChickenFarm();
            result = store.ship(unit); 
            matCells[unit] = "";
            locker.Release(); 
            return result;
        }

        public string getOneCell(int cellNo)
        {
            return matCells[cellNo]; //read data from one of the available matCells.
        }
    }
}
