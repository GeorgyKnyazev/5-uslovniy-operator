using System;

namespace _5_uslovniy_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float usdUserBalance;
            float rubUserBalance;
            float eurUserBalance;
            float usdConvertToEur = 1.1f;
            float usdConvertToRub = 64;
            float eurConvertToUsd = 0.9f;
            float eurConvertToRub = 56;
            float rubConvertToUsd = 0.015151f;
            float rubConvertToEur = 0.017241f;
            bool continueOperation = true;
            float theAmountOfMoneyToExchange;

            Console.Write("Укажите количество у вас долларов: ");
            usdUserBalance = Convert.ToSingle(Console.ReadLine());
            Console.Write("Укажите количество у вас рублей: ");
            rubUserBalance = Convert.ToSingle(Console.ReadLine());
            Console.Write("Укажите количество у вас евро: ");
            eurUserBalance = Convert.ToSingle(Console.ReadLine());

            while (continueOperation)
            {
                Console.WriteLine("Возможные типы операций");
                Console.WriteLine("1 - Обменять доллары на евро");
                Console.WriteLine("2 - обменять доллары на рубли");
                Console.WriteLine("3 - обменять евро на доллары");
                Console.WriteLine("4 - обменять евро на рубли");
                Console.WriteLine("5 - обменять рубли на доллары");
                Console.WriteLine("6 - обменять рубли на евро");
                Console.WriteLine("0 - выход");

                Console.Write("Введите тип операции: ");
                string selectedExchangeOperation = Console.ReadLine();
               
                switch (selectedExchangeOperation)
                {
                    
                    case "0":
                        continueOperation = false;
                        break;
                        
                    case "1":
                        Console.Write("Введите сумму которую хотите обменять: ");
                        theAmountOfMoneyToExchange = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine($"Вы хотите обменять {theAmountOfMoneyToExchange} долларов на евро");
                        if (usdUserBalance >= theAmountOfMoneyToExchange)
                        {
                            usdUserBalance -= theAmountOfMoneyToExchange;
                            eurUserBalance += theAmountOfMoneyToExchange * usdConvertToEur;
                        }
                        else
                        {
                            Console.WriteLine("У вас не достаточно денег на обмен");
                        }
                        break;

                    case "2":
                        Console.Write("Введите сумму которую хотите обменять: ");
                        theAmountOfMoneyToExchange = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine($"Вы хотите обменять {theAmountOfMoneyToExchange} долларов на рубли");
                        if (usdUserBalance >= theAmountOfMoneyToExchange)
                        {
                            usdUserBalance -= theAmountOfMoneyToExchange;
                            rubUserBalance += theAmountOfMoneyToExchange * usdConvertToRub;
                        }
                        else
                        {
                            Console.WriteLine("У вас не достаточно денег на обмен");
                        }
                        break;

                    case "3":
                        Console.Write("Введите сумму которую хотите обменять: ");
                        theAmountOfMoneyToExchange = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine($"Вы хотите обменять {theAmountOfMoneyToExchange} евро на доллары");
                        if (eurUserBalance >= theAmountOfMoneyToExchange)
                        {
                            eurUserBalance -= theAmountOfMoneyToExchange;
                            usdUserBalance += theAmountOfMoneyToExchange * eurConvertToUsd;
                        }
                        else
                        {
                            Console.WriteLine("У вас не достаточно денег на обмен");
                        }
                        break;
                    case "4":
                        Console.Write("Введите сумму которую хотите обменять: ");
                        theAmountOfMoneyToExchange = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine($"Вы хотите обменять {theAmountOfMoneyToExchange} евро на рубли");
                        if (eurUserBalance >= theAmountOfMoneyToExchange)
                        {
                            eurUserBalance -= theAmountOfMoneyToExchange;
                            rubUserBalance += theAmountOfMoneyToExchange * eurConvertToRub;
                        }
                        else
                        {
                            Console.WriteLine("У вас не достаточно денег на обмен");
                        }
                        break;

                    case "5":
                        Console.Write("Введите сумму которую хотите обменять: ");
                        theAmountOfMoneyToExchange = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine($"Вы хотите обменять {theAmountOfMoneyToExchange} рублей на доллары");
                        if (rubUserBalance >= theAmountOfMoneyToExchange)
                        {
                            rubUserBalance -= theAmountOfMoneyToExchange;
                            usdUserBalance += theAmountOfMoneyToExchange * rubConvertToUsd;
                        }
                        else
                        {
                            Console.WriteLine("У вас не достаточно денег на обмен");
                        }
                        break;

                    case "6":
                        Console.Write("Введите сумму которую хотите обменять: ");
                        theAmountOfMoneyToExchange = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine($"Вы хотите обменять {theAmountOfMoneyToExchange} рублей на евро");
                        if (rubUserBalance >= theAmountOfMoneyToExchange)
                        {
                            rubUserBalance -= theAmountOfMoneyToExchange;
                            eurUserBalance += theAmountOfMoneyToExchange * rubConvertToEur;
                        }
                        else
                        {
                            Console.WriteLine("У вас не достаточно денег на обмен");
                        }
                        break;
                }

                Console.WriteLine($"После обмена у вас: \n {usdUserBalance} долларов\n {eurUserBalance} евро\n {rubUserBalance} рублей");
            }
            
        }
    }
}
