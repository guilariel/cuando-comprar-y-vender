using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuando_comprar_y_vender
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] prices = [3, 2, 6, 5, 0, 3];

            MaxProfit(prices);
            Console.ReadLine();

        }
        public static int MaxProfit(int[] prices)
        {
            int profit = 0;
            int compra = prices[0];

            for (int i = 0; i < prices.Length; i++)
            {
                if (compra > prices[i])
                {
                    compra = prices[i];
                }
                if (profit < prices[i] - compra)
                    profit = prices[i] - compra;
            }

            if (profit > 0)
            {
                return profit;
            }
            else
            {
                return 0;
            }
        }
    }
}


/*               int compra = prices[0];

            for(int i = 0; i < prices.Length; i++)
            {
                int minVenta = prices.Skip(i).Max();
                if (compra > prices[i] && i + 1 < prices.Length)
                {
                    compra = prices[i];
                }

                if (profit < minVenta - prices[i])
                    profit = minVenta - prices[i];
            }             for (int j = i + 1;j < prices.Length; j++)
                {
                    if (venta < prices[j]) 
                    venta = prices[j];
                    
                    if (profit < prices[j] - prices[i])
                    profit = venta - compra;

                }
*/