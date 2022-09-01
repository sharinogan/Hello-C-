﻿using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int daysUntilExpiration = random.Next(12);
            int discountPercentage = 0;

            Console.WriteLine($"{daysUntilExpiration}");
            if (daysUntilExpiration <= 10)
            {
                Console.WriteLine("Your subscription will expire soon. Renew now!");
            }
            else if (daysUntilExpiration <= 5)
            {
                Console.WriteLine($"Your subscript expires in {daysUntilExpiration} days");
                discountPercentage = 10;
                Console.WriteLine($"Renew now and save {discountPercentage}%");
            }
            else if (daysUntilExpiration == 1)
            {
                Console.WriteLine("Your subscription expores within a day!");
                discountPercentage = 20;
                Console.WriteLine($"Renew now and save {discountPercentage}%");
            }
            else
            {
                Console.WriteLine("Your subscription has expired");
            }
        }
    }
}
