using System;

namespace _5_uslovniy_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float usdFromTheUser, rubFromTheUser, eurFromTheUser;
            float usdConvertToEur = 1.1f;
            float usdConvertToRub = 64;
            float eurConvertToUsd = 0.9f;
            float eurConvertToRub = 56;
            float rubConvertToUsd = 58;
            float rubConvertToEur = 66;
            bool continueOperation = true; 

            Console.Write("Укажите количество у вас долларов: ");
            usdFromTheUser = Convert.ToSingle(Console.ReadLine());
            Console.Write("Укажите количество у вас рублей: ");
            rubFromTheUser = Convert.ToSingle(Console.ReadLine());
            Console.Write("Укажите количество у вас евро: ");
            eurFromTheUser = Convert.ToSingle(Console.ReadLine());

            while (continueOperation)
            {
                Console.WriteLine("Возможные типы операций");
                Console.WriteLine("1 - Обменять доллары на евро");
                Console.WriteLine("2 - обменять доллары на рубли");
                Console.WriteLine("3 - обменять евро на доллары");
                Console.WriteLine("4 - обменять евро на рубли");
                Console.WriteLine("5 - обменять рубли на доллары");
                Console.WriteLine("6 - обменять рубли на евро");

                Console.Write("Введите тип операции: ");
                string selectedExchangeOperation = Console.ReadLine();
                Console.Write("Введите сумму которую хотите обменять: ");
                float theAmountOfMoneyToExchange = Convert.ToSingle(Console.ReadLine());

                switch (selectedExchangeOperation)
                {
                    case "1":
                        Console.WriteLine($"Вы хотите обменять {theAmountOfMoneyToExchange} долларов на евро");
                        if (usdFromTheUser >= theAmountOfMoneyToExchange)
                        {
                            usdFromTheUser -= theAmountOfMoneyToExchange;
                            eurFromTheUser += theAmountOfMoneyToExchange * usdConvertToEur;
                        }
                        else
                        {
                            Console.WriteLine("У вас не достаточно денег на обмен");
                        }
                        break;

                    case "2":
                        Console.WriteLine($"Вы хотите обменять {theAmountOfMoneyToExchange} долларов на рубли");
                        if (usdFromTheUser >= theAmountOfMoneyToExchange)
                        {
                            usdFromTheUser -= theAmountOfMoneyToExchange;
                            rubFromTheUser += theAmountOfMoneyToExchange * usdConvertToRub;
                        }
                        else
                        {
                            Console.WriteLine("У вас не достаточно денег на обмен");
                        }
                        break;

                    case "3":
                        Console.WriteLine($"Вы хотите обменять {theAmountOfMoneyToExchange} евро на доллары");
                        if (eurFromTheUser >= theAmountOfMoneyToExchange)
                        {
                            eurFromTheUser -= theAmountOfMoneyToExchange;
                            usdFromTheUser += theAmountOfMoneyToExchange * eurConvertToUsd;
                        }
                        else
                        {
                            Console.WriteLine("У вас не достаточно денег на обмен");
                        }
                        break;
                    case "4":
                        Console.WriteLine($"Вы хотите обменять {theAmountOfMoneyToExchange} евро на рубли");
                        if (eurFromTheUser >= theAmountOfMoneyToExchange)
                        {
                            eurFromTheUser -= theAmountOfMoneyToExchange;
                            rubFromTheUser += theAmountOfMoneyToExchange * eurConvertToRub;
                        }
                        else
                        {
                            Console.WriteLine("У вас не достаточно денег на обмен");
                        }
                        break;

                    case "5":
                        Console.WriteLine($"Вы хотите обменять {theAmountOfMoneyToExchange} рублей на доллары");
                        if (rubFromTheUser >= theAmountOfMoneyToExchange)
                        {
                            rubFromTheUser -= theAmountOfMoneyToExchange;
                            usdFromTheUser += theAmountOfMoneyToExchange / rubConvertToUsd;
                        }
                        else
                        {
                            Console.WriteLine("У вас не достаточно денег на обмен");
                        }
                        break;

                    case "6":
                        Console.WriteLine($"Вы хотите обменять {theAmountOfMoneyToExchange} рублей на евро");
                        if (rubFromTheUser >= theAmountOfMoneyToExchange)
                        {
                            rubFromTheUser -= theAmountOfMoneyToExchange;
                            eurFromTheUser += theAmountOfMoneyToExchange / rubConvertToEur;
                        }
                        else
                        {
                            Console.WriteLine("У вас не достаточно денег на обмен");
                        }
                        break;
                }

                Console.WriteLine($"После обмена у вас: \n {usdFromTheUser} долларов\n {eurFromTheUser} евро\n {rubFromTheUser} рублей");
                Console.Write("Повторить обмен?(True или false): ");
                continueOperation = Convert.ToBoolean(Console.ReadLine());
            }
            
        }
    }
}
