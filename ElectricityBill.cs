using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4._3
{
    public class ElectricityBill
    {
        public int CustomerId;
        public string CustomerName;
        public double Consumption;

        public ElectricityBill()
        {
            Console.Write("Customer ID: ");
            CustomerId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Customer Name: ");
            CustomerName = Console.ReadLine();
            Console.Write("Consumption: ");
            Consumption = Convert.ToDouble(Console.ReadLine());
        }

        public ElectricityBill(int customerId, string customerName, double consumption)
        {
            CustomerId = customerId;
            CustomerName = customerName;
            Consumption = consumption;
        }

        public void DisplayCalculation()
        {
            Console.WriteLine($"Customer IDNO: {CustomerId}");
            Console.WriteLine($"Customer Name: {CustomerName}");
            Console.WriteLine($"Unit Consumed: {Consumption}kWh\n");

            double[] consumptionByTier = [Consumption, 0, 0, 0];
            double[] priceByTier = [1.20, 1.50, 1.80, 2.00];
            double netAmount = 0;

            // divide up consumption by price tier
            for (int i = 1; i < consumptionByTier.Length; i++)
            {
                if (consumptionByTier[i-1]>200)
                {
                    consumptionByTier[i] = consumptionByTier[i-1] - 200;
                    consumptionByTier[i - 1] = 200;
                }
            }

            if (consumptionByTier[0] < 0)
            {
                Console.WriteLine("Negative Consumption.");
            }
            else
            {
                // line by line
                for (int i = 0; i < consumptionByTier.Length; i++)
                {
                    Console.WriteLine($"{consumptionByTier[i]}kWh @ {priceByTier[i]:C2}/kWh" +
                        $" = {(consumptionByTier[i] * priceByTier[i]):C2}");
                    netAmount += consumptionByTier[i] * priceByTier[i];
                }
            }

            // surcharge
            if(Consumption>400)
            {
                Console.WriteLine($"Surcharge Amount: {(0.15*netAmount):C2}");
                netAmount += 0.15 * netAmount;
            }

            Console.WriteLine($"Net Amount Paid By the Customer : {netAmount:C2}");

        }
    }
}
