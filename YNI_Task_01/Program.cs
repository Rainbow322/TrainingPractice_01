﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YNI_Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int gold = 0;
            int crystalsToBuy = 0;
            const int crystalCost = 15;

            Console.WriteLine($"Курс кристаллов к золоту - 1 : {crystalCost}");
        inputGoldErr:
            Console.Write("Введите количество своего золота: ");
            try
            {
                gold = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("\nНужно ввести цифры");
                goto inputGoldErr;
            }

            if (gold < 0)
            {
                Console.WriteLine("\nвам не хватает средств на совершение сделки.");
                Console.Write("У вас нет кристаллов, и не хватает золота");
            }
            else if (gold < crystalCost)
            {
                Console.WriteLine("\nУ вас не хватает золота даже на один кристалл.");
                Console.WriteLine($"У вас {gold} золота и {crystalsToBuy} кристаллов.");
            }
            else
            {
            inputCrystalsErr:
                Console.WriteLine("\nСколько кристаллов вы хотите приобрести?");

                try
                {
                    crystalsToBuy = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Нужно ввести цифры");
                    goto inputCrystalsErr;
                }


                if (crystalsToBuy * crystalCost > gold)
                {
                    Console.WriteLine("\nне хватает");
                    crystalsToBuy = 0;
                    Console.WriteLine($"У вас {gold} золота и {crystalsToBuy} кристаллов.");
                }
                else
                {
                    gold -= crystalsToBuy * crystalCost;
                    Console.WriteLine($"\nУ вас {gold} золота и {crystalsToBuy} кристаллов.");

                }
            }
            Console.ReadKey();
        }
    }
}
